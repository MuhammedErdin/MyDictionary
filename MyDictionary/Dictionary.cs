using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public Dictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key id, Value name)
        {
            Key[] tempkey = keys;
            Value[] tempvalue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
                values[i] = tempvalue[i];
            }
            keys[keys.Length - 1] = id;
            values[values.Length - 1] = name;
        }

        public int KLenght
        {
            get { return keys.Length; }
        }

        public Key[] TitleK
        {
            get { return keys; }
        }

        public Value[] TitleV
        {
            get { return values; }
        }
    }
}