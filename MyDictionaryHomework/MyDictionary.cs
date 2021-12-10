using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomework
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] tKeys;
        TValue[] tValues;

        public MyDictionary()
        {
            tKeys = new TKey[0];
            tValues = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            if (Array.IndexOf(tKeys, key) == -1)
            {
                TKey[] tempKeys = tKeys;
                TValue[] tempValues = tValues;
                tKeys = new TKey[tKeys.Length + 1];
                tValues = new TValue[tValues.Length + 1];
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    tKeys[i] = tempKeys[i];
                    tValues[i] = tempValues[i];
                }
                tKeys[tKeys.Length-1] = key;
                tValues[tValues.Length-1] = value;
            }
            else
            {
                Console.WriteLine("Anahtar Zaten Kullanılıyor");
            }

        }

        public void GetDictionary()
        {
            for (int i = 0; i < tKeys.Length; i++)
            {
                Console.WriteLine("key : " + tKeys[i]+ " Value : " + tValues[i]);
            }

        }


    }
}
