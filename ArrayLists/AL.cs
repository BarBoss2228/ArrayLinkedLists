using System;

namespace ArrayLists
{
    public class AL
    {
        private int[] _array;
        private int _Length;

        public AL()
        {
            _array = new int[10];
            _Length = 0;
        }

        public AL(int value)
        {
            _array = new int[10];
            _Length = 1;
            _array[0] = value;
        }
        public AL(int[] array)
        {
            _array = new int[10];
            _Length = 0;
            EnlargeMyArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            _Length += array.Length;
            
        }

        public void PrintArray()
        {
            for (int i = 0; i < _Length; i++)
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
            for (int i = 0; i < _Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public int GetLength()
        {
            return _Length;
        }
        public int[] ToArray()
        {
            int[] newArr = new int[_Length];
            for (int i = 0; i < _Length; i++)
            {
                newArr[i] = _array[i];
            }
            return newArr;
        }
        
        public void RemoveFirst()
        {
            for (int i = 0; i < _Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            _Length--;
        }
        public void RemoveLast()
        {
            _Length--;
        }

        public void RemoveAt(int idx)
        {
            for (int i = idx; i < _Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            _Length--;
        }

        public void RemoveFirstMultiple(int n) // - удаление первых n элементов
        {
            for (int i = n; i < _Length; i++)
            {
                _array[i - n] = _array[i];
            }
            _Length -= n;
        }

        public void RemoveLastMultiple(int n) //- удаление последних n элементов
        {
            _Length -= n;
        }

        public void RemoveAtMultiple(int idx, int n) //- удаление n элементов, начиная с указанного индекса
        {
            for (int i = idx; i < idx + n; i++)
            {
                _array[i] = _array[i+n];
            }
            _Length -= n;
        }




    }
}
