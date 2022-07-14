using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    public class MyArrayListEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int _currentIndex;
        public MyArrayListEnumerator(T[] array)
        {
            _array = array;
            _currentIndex = -1;
        }
        public T Current => _array[_currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _array.Length;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
