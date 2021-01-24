using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class DictionaryManager<TKey,TValue>
    {
        TKey[] kArray;
        TValue[] vArray;
        TKey[] tempKArray;
        TValue[] tempVArray;

        public DictionaryManager()
        {
            kArray = new TKey[0];
            vArray = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            tempKArray = kArray;
            tempVArray = vArray;

            kArray = new TKey[kArray.Length + 1];
            vArray = new TValue[vArray.Length + 1];
            for (int i = 0; i < tempKArray.Length; i++)
            {
                kArray[i] = tempKArray[i];

            }
            for (int i = 0; i < tempVArray.Length; i++)
            {
                vArray[i] = tempVArray[i];
            }
            kArray[kArray.Length - 1] = key;
            vArray[vArray.Length - 1] = value;
        }
        public TKey[] Item1
        {
            get { return kArray; }
        }

        public TValue[] Item2
        {
            get { return vArray; }

        }

    }
}
