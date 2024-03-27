using System;
using System.Collections.Generic;

namespace Utility.DataStructures
{
    [Serializable]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public List<TKey> keys = new();
        public List<TValue> values = new();
    }
}
