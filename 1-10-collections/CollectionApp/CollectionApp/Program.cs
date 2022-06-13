using System;
using System.Collections;
using System.Text;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("1. add element to the end of colelction");
                Console.WriteLine("2. insert element according to the index");
                Console.WriteLine("3. replace element by index");
                Console.WriteLine("4. remove all values for collection");
                Console.WriteLine("5. remove value by index");
                Console.WriteLine("6. reverses collection");
                Console.WriteLine("7. sort collection");
                Console.WriteLine("8. clear collection");
                Console.WriteLine("9. find value in collection");
                Console.WriteLine("10. get index of element equal to input value");
                Console.WriteLine("11. add multiple elements to the end of collection");
                Console.WriteLine("12. indexers: get - returns element by index, set - inserts element by index");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        ;
                        break;
                    case "3":
                        ;
                        break;
                    case "4":
                        ;
                        break;
                    case "5":
                        ;
                        break;
                    case "6":
                        ;
                        break;
                    case "7":
                        ;
                        break;
                    case "8":
                        ;
                        break;
                    case "9":
                        ;
                        break;
                    case "10":
                        ;
                        break;
                    case "11":
                        ;
                        break;
                    case "12":
                        ;
                        break;
                    case "Exit":
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid data, try again!");
                        break;
                        
                }
                    
            }
        }
    }
    public class MyArrayList<T> : IEnumerable<T>, IEquatable<T>
    {
        private T[] _array;
        private int _lastAvailableIndex;
        public MyArrayList(int size)
        {
            _array = new T[size];
            _lastAvailableIndex = 0;
        }
        public void Add(T value)
        {
            _array[_lastAvailableIndex] = value;
            _lastAvailableIndex++;
        }
        public void InsertElementByIndex(T[] _newArray, int myIndex, T value)
        {
            foreach (T element in _array)
            {
                if(element != null)
                {
                    _newArray = new T[_array.Length * 2];
                }
            }
            _newArray[myIndex] = value;
            for (int i = 0; i < myIndex; i++)
            {
                _newArray[i] = _array[i];
            }
            for(int i = myIndex; i < _array.Length; i++)
            {
                _newArray[i + 1] = _array[i];
            }
        }
        public void ReplaceElementByIndex(int myIndex, T value)
        {
            _array[myIndex] = value;
            Console.WriteLine($"Element number {0} is {1}", myIndex, value);
        }
        public void RemoveSimilar(T[] _newArray, T value)
        {
            _newArray = _array;
            foreach(T element in _newArray)
            {
                if (element.Equals(value))
                {
                    //_newArray.Remove(element);
                }
            }
            
        }
        public void RemoveElementByIndex(T[] _newArray, int myIndex)
        {
            _newArray = new T[_array.Length - 1];
            for (int i = 0; i < myIndex; i++)
            {
                _newArray[i] = _array[i];
            }
            for (int i = myIndex + 1; i < _array.Length; i++)
            {
                _newArray[i - 1] = _array[i];
            }
        }
        public void Reverse()
        {
            for(int i = _array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public void Clear(T[] _newArray)
        {
            _array = _newArray;
            //foreach(T element in _array)
            //{
            //    element.Equals(null);
            //}
            //_array.ToList().Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyArrayListEnumerator<T>(_array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Equals(T? other)
        {
            throw new NotImplementedException();
        }
    }
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

        public void Dispose(){}

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