using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueIndexer
{
    class MyDictionary
    {
        
        
       
        public int Capacity { get; set; }
        public KeyValue[] Values { get; set; }
        public int Count { get; set; }
        public MyDictionary()
        {
            Capacity = 10;
            Values = new KeyValue[Capacity];
        }
        public object this[string key]
        {
            get
            {
                foreach (KeyValue item in Values)
                {
                    if (item.Key == key) return item.Value;
                }
                throw new KeyNotFoundException();
            }
            set
            {
                if (Count == Capacity) throw new Exception("My Dictionary is full");
                for (int i = 0; i < Capacity; i++)
                {
                    if (Values[i].Key == key)
                    {
                        Values[i].Value = value;
                        return;
                    }
                }
                Values[Count] = new KeyValue(key, value);
                Count++;
            }
        }

    }
}
