using System;

namespace Lab_2
{
    public class MyList<T>
    {
        private T[] _list;
        
        public MyList()
        {
            _list = new T[4];
            Length = 0;
        }

        private int Capacity => _list.Length;
        
        private void DoubleCapacity()
        {
            T[] temp = new T[Capacity * 2];
            for (var i = 0; i < _list.Length; i++)
                temp[i] = _list[i];

            _list = temp;
        }
        
        public int Length { get; private set; }
        
        public void Add(T item)
        {
            if (Length >= Capacity) DoubleCapacity();

            _list[Length] = item;
            Length++;
        }
        
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return _list[i];
            }
        }
    }
}