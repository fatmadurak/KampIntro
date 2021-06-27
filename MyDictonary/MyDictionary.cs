using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMyDictonary
{
  public  class MyDictionary<TKey,TValue>
    {

        TKey[] key;
        TValue[] value;
        TKey[] _tempArrayKey;
        TValue[] _tempArrayValue;

        public MyDictionary()
        {
            key = new TKey[0];
            value = new TValue[0];
        }


        public void Add(TKey key1, TValue value1) 
        {

         

            _tempArrayKey = key;
            _tempArrayValue = value;

            key = new TKey[key.Length+1];
            value = new TValue[value.Length+1];

            for (int i = 0; i < _tempArrayKey.Length && i<_tempArrayValue.Length; i++)
            {

                key[i] = _tempArrayKey[i];
                value[i] = _tempArrayValue[i];


            }

            key[key.Length - 1] = key1;
            value[value.Length - 1] = value1;
        
        }


        private int count;

        public int Count
        {
            get { return key.Length; }
           
        }

        public TKey[] Key
        {
            get { return key; }
           

        }

    
        public TValue[] Value
        {
            get { return value; }
     

        }

      

      






    }
}
