using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayLists
{
    public class AL
    {
        private int[] _array; // - 
        private int _currentLength; // - used length
        private const int _minLength = 10;

        public AL()
        {
            _array = new int[_minLength];
            _currentLength = 0;
        }

        public AL(int value)
        {
            _array = new int[_minLength];
            _currentLength = 1;
            _array[0] = value;
        }
        public AL(int[] array)
        {
            _array = new int[_minLength];
            _currentLength = 0;
            EnlargeMyArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            _currentLength += array.Length;
            
        }

        public void PrintArray()
        {
            for (int i = 0; i < _currentLength; i++)
            {
                Console.Write($"{_array[i]} ");
            }
        }

        private void EnlargeMyArray(int requiredLength)
        {
            if (requiredLength <= _array.Length)
            {
                return;
            }
            int tmp = _array.Length;
            while(tmp < requiredLength)
            {
                tmp = 3 * tmp / 2;
            }
            int[] newArray = new int[tmp];
            for (int i = 0; i < _currentLength; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public void MakeShorterArray()
        {
            int targetLength = _array.Length;

            while (targetLength > _minLength && targetLength > _currentLength)
            {
                if (targetLength * 2 % 3 == 0)
                {
                    targetLength = targetLength * 2 / 3;
                }
                else
                {
                    targetLength = targetLength * 2 / 3 + 1;
                }

            }
            if(targetLength < _currentLength)
            {
                targetLength = targetLength * 3 / 2;
            }
            if (targetLength == _array.Length)
            {
                return;
            }
            int[] newArray = new int[targetLength];
            for (int i = 0; i < _currentLength; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public int GetLength()
        {
            return _currentLength;
        }
        public int[] ToArray()
        {
            int[] newArr = new int[_currentLength];
            for (int i = 0; i < _currentLength; i++)
            {
                newArr[i] = _array[i];
            }
            return newArr;
        }
        
        public void RemoveFirst()
        {
            for (int i = 0; i < _currentLength; i++)
            {
                _array[i] = _array[i + 1];
            }
            _currentLength--;
        }
        public void RemoveLast()
        {
            _currentLength--;
        }

        public void RemoveAt(int idx)
        {
            for (int i = idx; i < _currentLength; i++)
            {
                _array[i] = _array[i + 1];
            }
            _currentLength--;
        }

        public void RemoveFirstMultiple(int n) // - удаление первых n элементов
        {
            for (int i = n; i < _currentLength; i++)
            {
                _array[i - n] = _array[i];
            }
            _currentLength -= n;
        }

        public void RemoveLastMultiple(int n) //- удаление последних n элементов
        {
            _currentLength -= n;
        }

        public void RemoveAtMultiple(int idx, int n) //- удаление n элементов, начиная с указанного индекса
        {
            if (idx < 0|| idx >=_currentLength)
            {
                throw new IndexOutOfRangeException();
            }
            if(n < 0)
            {
                throw new ArgumentException("Элементов должно быть больше 0");
            }
            if (n == 0)
            {
                return;
            }
            if (n + idx >_currentLength)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = _currentLength - 1; i >= idx + n; i--)
            {
                _array[i-n] = _array[i];
            }
            _currentLength -= n;
            MakeShorterArray();
            // TODO: заполнить неиспользованное место 0; 
        }

        public override bool Equals(object obj)
        {
            return obj is AL aL &&
                   Enumerable.SequenceEqual(aL._array, _array) &&
                   _currentLength == aL._currentLength;
        }
    }
}
