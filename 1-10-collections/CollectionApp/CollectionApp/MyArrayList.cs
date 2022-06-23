using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    public class MyArrayList<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _lastAvailableIndex;
        public MyArrayList()
        {
            _array = new T[8];
            _lastAvailableIndex = 0;
        }
        public void Add(T value)
        {
            _array[_lastAvailableIndex] = value;
            _lastAvailableIndex++;
        }
        public void InsertElementByIndex(int myIndex, T value)
        {
            var newArray = new T[_array.Length];
            if (_array[^1] != null)
            {
                newArray = new T[_array.Length * 2];
            }
            newArray[myIndex] = value;
            for (int i = 0; i < myIndex; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = myIndex; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _lastAvailableIndex++;
        }
        public void ReplaceElementByIndex(int myIndex, T value)
        {
            _array[myIndex] = value;
            Console.WriteLine($"Element number {0} is {1}", myIndex, value);
        }
        public void RemoveSimilar(T value)
        {
            var newArray = new List<T>(_array);
            foreach (T element in newArray)
            {
                if (element.Equals(value))
                {
                    newArray.Remove(element);
                }
            }
            var finalArray = newArray.ToArray();
        }
        public void RemoveElementByIndex(int myIndex)
        {
            var newArray = new T[_array.Length - 1];
            for (int i = 0; i < myIndex; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = myIndex + 1; i < _array.Length; i++)
            {
                newArray[i - 1] = _array[i];
            }
            _array = newArray;
        }
        public void Reverse()
        {
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                Console.Write(_array[i]);
            }
            Console.WriteLine();
        }
        public T[] Sort(IComparer<T> comparer)
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int j = 0; j < _array.Length - i - 1; j++)
                {
                    if (comparer.Compare(_array[j], _array[j + 1]) > 0)
                    {
                        var add = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = add;
                    }
                }
            }
            return _array;
        }
        public void Clear()
        {
            foreach (T element in _array)
            {
                _array = null;
                _lastAvailableIndex = 0;
            }
        }
        public bool Contain(T value)
        {
           for(int i = 0; i < _array.Length; i++)
           {
                if(_array[i].Equals(value))
                {
                    return true;
                }
           }
           return false;
        }
        public int GetIndexOf(T value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(value))
                {
                    return i;
                }
            }
            Console.WriteLine("There is no index for such value");
            return -1;
        }
        public void AddMany(T[] value)
        {
            for(int i = 0; i < value.Length; i++)
            {
                _array[_lastAvailableIndex] = value[i];
                _lastAvailableIndex++;
            }
        }
        public void Indexers(int index, T value)
        {
            Console.WriteLine("1 - get, 2 - set, choose action...");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine(_array[index]);
            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                ReplaceElementByIndex(index, value);
            }
            else
            {
                Console.WriteLine("aiaiai");
            }
        }
        public bool Contain(T value, IComparer<T> comparer)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (comparer.Compare(_array[i], value) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void RemoveSimilar(T value, IComparer<T> comparer)
        {
            var newArray = new ArrayList(_array);
            foreach (T element in newArray)
            {
                if (comparer.Compare(element, value) == 0)
                {
                    newArray.Remove(element);
                }
            }
            var finalArray = newArray.ToArray();
        }
        public int GetIndexOf(T value, IComparer<T> comparer)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (comparer.Compare(_array[i], value) == 0)
                {
                    return i;
                }
            }
            Console.WriteLine("There is no index for such value");
            return -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyArrayListEnumerator<T>(_array);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
