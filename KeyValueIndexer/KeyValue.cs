﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueIndexer
{
    
    public struct KeyValue
    {
        public KeyValue(string key, object value)
        {
            Key = key;
            Value = value;
        }

        public string Key {get; set;}
    public Object Value { get; set; }

    }
}
