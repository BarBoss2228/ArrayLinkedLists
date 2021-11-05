using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayLists
{
    public class AL
    {
        private int[] _array; // - поле, извне не меняетсяб в нем содержится массив с длиной 10
        private int _currentLength; // - used length, c точки зрения пользователя
        private const int _minLength = 10; // - минимальная длина внутреннего массива

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
            EnlargeMyArray();
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

        private void EnlargeMyArray()
        {
            int requiredLength = _currentLength;
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
        public void AddFirst(int value) //добавление в начало списка
        {
            int oldLenght = _currentLength;
            _currentLength++;
            for (int i = oldLenght - 1; i >= _array.Length; i++)
            {
                _array[i + 1] = _array[i];
            }
            _array[0] = value;

        }
        public void AddFirst(AL list) //- то же самое, но слияние двух списков
        {
            _currentLength = list._currentLength + _currentLength;
            EnlargeMyArray();
            for (int i = 0; i < _currentLength; i++)
            {
                _array[i + list._currentLength] = _array[i];
            }
            for (int i = 0; i < _currentLength; i++)
            {
                _array[i] = list._array[i];
            }


        }
        public void AddLast(int value) //-добавление в конец списка
        {
            int oldLenght = _currentLength;
            _currentLength++;

            _array[oldLenght] = value;

        }
        public void AddLast(AL list) //- то же самое, но слияние двух списков
        {
            _currentLength = list._currentLength + _currentLength;
            EnlargeMyArray();
            for (int i = _currentLength - list._currentLength - 1; i < _currentLength; i++)
            {
                _array[i] = list._array[i];
            }
        }
        public void AddAt(int idx, int value) // вставка по указанному индексу
        {
            if (idx < 0 || idx > _currentLength)
            {
                throw new IndexOutOfRangeException();
            }
            int oldLenght = _currentLength;
            _currentLength++;
            for (int i = idx; i >= _array.Length; i++)
            {
                _array[i + 1] = _array[i];
            }
            _array[idx] = value;

        }
        public void AddAt(int idx, AL list) // то же самое, только с самодельным списком
        {
            _currentLength = list._currentLength + _currentLength;
            EnlargeMyArray();
            for (int i = idx; i < _currentLength; i++)
            {
                _array[list._currentLength + i] = _array[i];
            }
            for (int i = idx; i < list._currentLength + idx; i++)
            {
                _array[i] = list._array[i];
            }

        }
        public void Set(int idx, int value) //поменять значение элемента по указанному индексу
        {
            if (idx < 0 || idx > _currentLength)
            {
                throw new IndexOutOfRangeException();
            }
            _array[idx] = value;
        }

        public void RemoveFirst() // удаление первого элемента
        {
            for (int i = 0; i < _currentLength; i++)
            {
                _array[i] = _array[i + 1];
            }
            _currentLength--;
        }
        public void RemoveLast() // удаление последнего элемента
        {
            _currentLength--;
        }

        public void RemoveAt(int idx) // удалеие по индексу
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
        public int RemoveFirst(int val) // удалить первый попавшийся элемент(равный value) и вернуть индекс
        {
            int index = -1;
            for (int i = 0; i < _currentLength; i++)
            {
                if (_array[i] == val)
                {
                    RemoveAt(i);
                    index = i;
                    return index;

                }

            }
            _currentLength--;
            MakeShorterArray();
            return index;


        }
        public int RemoveAll(int value) //удалить все элементы равные val и вернуть количество удаленных элементов
        {
            int counter = 0;
            for (int i = 0; i < _currentLength; i++)
            {
                if (_array[i] == value)
                {
                    RemoveAt(i);
                    counter++;
                }

            }
            _currentLength--;
            MakeShorterArray();
            return counter;

        }
        public bool Contains(int value) // проверить, есть ли элемент в списке
        {
            for (int i = 0; i < _currentLength; i++)
            {
                if (_array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(int value) // вернет индекс первого найденного элемента, равного вал или -1
        {
            int index = -1;
            for (int i = 0; i < _currentLength; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    return index;

                }

            }


            return index;
        }
        public int GetFirst() // вернет значение первого
        {
            return _array[0];
        }

        public int GetLast() // вернет значение последнего элемента
        {
            return _array[_currentLength - 1];
        }

        public int Get(int index) // вернет значение элемента с указанным индексом
        {
            if (index >= _currentLength - 1)
            {
                throw new IndexOutOfRangeException("Нет такого индекса");
            }
            return _array[index];
        }

        public void Reverse() //изменеие порядка списка на обратый
        {
            for (int i = 0; i < _currentLength / 2; i++)
            {
                int tmp = _array[i];
                _array[i] = _array[_currentLength - 1 - i];
                _array[_currentLength - 1 - i] = tmp;
            }
        }
        public int Max() // поиск максимального элемента
        {
            int max = _array[0];
            for (int index = 0; index < _currentLength; index++)
            {
                if (_array[index] > max)
                {
                    max = _array[index];
                }
            }
            return max;
        }

        public int Min() // поиск минимального элемента
        {
            int min = _array[0];
            for (int index = 0; index < _currentLength; index++)
            {
                if (_array[index] < min)
                {
                    min = _array[index];
                }
            }
            return min;
        }

        public int IndexOfMax() // поиск индекса максимального элемента
        {
            int maxValue = _array[0];
            int index = 0;
            for (int i = 0; i < _currentLength; i++)
            {
                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                    index = i;
                }
            }
            return index;
        }
        public int IndexOfMin() // поиск индекса минимального элемента
        {
            int minValue = _array[0];
            int index = 0;
            for (int i = 0; i < _currentLength; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                    index = i;
                }
            }
            return index;
        }

        public void Sort() // - сортировка по возрастанию пузырьком
        {
            int b, c;
            for (b = 0; b < _currentLength; b++)
            {
                for (int i = 0; i < _currentLength - 1; i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        c = _array[i];
                        _array[i] = _array[i + 1];
                        _array[i + 1] = c;
                    }
                }
            }
        }

        public void SortDec() // - сортировка по убыванию Select
        {
            int min = _array[0];
            int temp = 0;
            int idx = 0;
            for (int i = 0; i < _currentLength - 1; i++)
            {
                idx = i;
                for (int j = i + 1; j < _currentLength; j++)
                {
                    if (_array[idx] < _array[j])
                    {

                        idx = j;
                    }

                }
                temp = _array[i];
                _array[i] = _array[idx];
                _array[idx] = temp;
            }
        }


        public override bool Equals(object obj)
        {
            return obj is AL aL &&
                   Enumerable.SequenceEqual(aL._array, _array) &&
                   _currentLength == aL._currentLength;
        }
    }
}
