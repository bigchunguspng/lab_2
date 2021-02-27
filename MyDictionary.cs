using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        
        public MyDictionary()
        {
            _keys = new TKey[4];
            _values = new TValue[4];
            Length = 0;
        }

        private int Capacity => _keys.Length;
        
        private void DoubleCapacity<T>(ref T[] list)
        {
            T[] temp = new T[Capacity * 2];
            for (var i = 0; i < list.Length; i++)
                temp[i] = list[i];

            list = temp;
        }
        
        public int Length { get; private set; }

        public void Add(TKey key, TValue value)
        {
            if (_keys.Contains(key))
                throw new ArgumentException();

            if (Length >= Capacity)
            {
                DoubleCapacity(ref _keys);
                DoubleCapacity(ref _values);
            }

            _keys[Length] = key;
            _values[Length] = value;

            Length++;
        }

        public TValue this[TKey key]
        {
            get
            {
                if (!_keys.Contains(key))
                    throw new KeyNotFoundException();

                return _values[Array.IndexOf(_keys, key)];
            }
        }
    }
}