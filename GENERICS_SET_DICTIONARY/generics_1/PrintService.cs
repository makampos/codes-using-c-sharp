using System;

namespace generics_1
{
    public class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue (T value) 
        {
            if (_count == 10) 
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First() 
        {
            if (_count == 0) 
            {
                throw new InvalidOperationException("PrintService is full");
            }
            return _values[0];
        }

        public void Print() 
        {
            System.Console.Write("[");
            for (int i = 0; i < _count -1; i++) 
            {
                System.Console.Write(_values[i] + ", ");
            }

            if (_count > 0) 
            {
                System.Console.Write(_values[_count - 1]);
            }

            System.Console.Write("]");
        }
    }
}