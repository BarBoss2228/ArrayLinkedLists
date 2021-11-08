using System;

namespace LinkedList
{
    public class LL
    {
        private Node _head;
        private Node _tail;

        public LL() // - пустой конструктор
        {
            _head = null;
            _tail = null;
        }
        public LL(int value) // - на основе одного элемента
        {
            _head = new Node(value);
            _tail = null;
        }
        public LL(int [] array) // - конструктор на основе массива
        {
            if(array.Length == 0)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = new Node(array[0]);
                _tail = _head;
                for (int i = 1; i < array.Length; i++)
                {
                    _tail.Next = new Node(array[i]);
                    _tail = _tail.Next;
                }
            }
        }
        public int GetLength() // - узнает количество элементов в массиве
        {
            int length = 0;
            if (_head == null && _tail == null)
            {
                return length;
            }
            else
            {
                Node current = _head;
                length = 1;
                while (current.Next != null)
                {
                    current = current.Next;
                    length++;
                }
            }
            return length;

        }
        public int[] ToArray() // - вернет хранимые данные в виде массива
        {
            int length = GetLength();
            int[] array = new int[length];
            if (length == 0)
            {
                return array;
            }
            array[0] = _head.Value;
            Node current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                current = current.Next;
                array[i] = current.Value;
            }
            return array;
        }
        public void PrintArray(LL list) // - вывод массива в консоль
        {
            int[] array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public void AddFirst(int value) // - добавление в начало списка
        {
            if (_head == null && _tail == null)
            {
                _head = new Node(value);
                _tail = _head;
                return;
            }
            Node tmp = new Node(value);
            tmp.Next = _head;
            _head = tmp;
        }
        public void AddFirst(LL list) // - то же самое, но с вашим самодельным классом (т.е. слияние двух списков)
        {
            list._tail.Next = _head;
            _head = list._head;
        }
        public void AddLast(int val) // - добавление в конец списка
        {
            if (_head == null && _tail == null)
            {
                _head = new Node(val);
                _tail = _head;
            }
            else
            {
                _tail.Next = new Node(val);
                _tail = _tail.Next;
            }
        }
        public void AddLast(LL list) // - то же самое, но с вашим самодельным классом (т.е. слияние двух списков)
        {
            _tail.Next = list._head;
            _tail = list._tail;
        }
        //TODO разобраться с тестом
        public void AddAt(int idx, int val) // - вставка по указанному индексу
        {
            int length = GetLength();
            if (idx >= length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            Node current = _head;
            if (idx == 0)
            {
                AddFirst(val);
            }
            else
            {
                for (int i = 0; i < idx; i++)
                {
                    current = current.Next;
                }
                Node tmp = new Node(val);
                tmp.Next = current.Next;
                current.Next = tmp;
            }
        }
        public void AddAt(int idx, LL list) // - вставка по указанному индексу с самодельным классом
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            if (idx == 0)
            {
                AddFirst(list);
            }
            Node current = _head;

            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            list._tail.Next = current.Next;
            current.Next = list._head;
        }
        public void Set(int idx, int val) // - поменять значение элемента с указанным индексом
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            else if (idx == 0 && length == 1)
            {
                _head = new Node(val);
            }
            else
            {
                Node current = _head;
                for (int i = 0; i < idx; i++)
                {
                    current = current.Next;
                }
                current.Value = val;

            }
        }
        public void RemoveFirst() //- удаление первого элемента
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            if (_head.Next == null)
            {
                _head = null;
                _tail = null;
                return;
            }
            _head = _head.Next;
        }
        public void RemoveLast() // - удаление последнего элемента
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            if (_head.Next == null)
            {
                _head = null;
                _tail = null;
                return;
            }
            Node current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            _tail = current;
            current.Next = null;
        }
        public void RemoveAt(int idx) // -  удаление по индексу
        {
            int length = GetLength();
            if (idx >= length)
            {
                throw new IndexOutOfRangeException("Такого числа нет");
            }
            if (idx == 0)
            {
                RemoveFirst();
                return;
            }
            if (idx == length - 1)
            {
                RemoveLast();
                return;
            }
            Node current = _head;

            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
        }
        
        public void RemoveFirstMultiple(int n) // - удаление первых n элементов
        {
            int length = GetLength();
            if (n > length || _head == null)
            {
                throw new Exception();
            }
            if (n == length)
            {
                _head = null;
                _tail = null;
                return;
            }
            Node current = _head;

            for (int i = 1; i < n; i++)
            {
                current = current.Next;
            }
            _head = current.Next;
        }
        public void RemoveLastMultiple(int n) // - удаление последних n элементов 
        {
            int length = GetLength();
            if (n > length || _head == null)
            {
                throw new Exception();
            }
            if (n == length)
            {
                _head = null;
                _tail = null;
                return;
            }
            Node current = _head;
            for (int i = 1; i < length - n; i++)
            {
                current = current.Next;
            }
            _tail = current;
            current.Next = null;
        }
        public void RemoveAtMultiple(int idx, int n) // - удаление n элементов, начиная с указанного индекса
        {
            int length = GetLength();
            if (idx + n > length || _head == null)
            {
                throw new Exception();
            }
            if (length - n == idx)
            {
                RemoveLastMultiple(n);
                return;
            }
            if (idx == 0)
            {
                RemoveFirstMultiple(n);
                return;
            }
            Node current = _head;
            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            for (int i = 1; i <= n; i++)
            {
                current.Next = current.Next.Next;
            }

        }
        public void RemoveFirst(int val) //- удалить первый попавшийся элемент, значение которого равно val(вернуть индекс удалённого элемента)
        {
            _head = _head.Next;
        }

        public int RemoveAll(int val) // - удалить все элементы, равные val (вернуть кол-во удалённых элементов)
        {
            if (_head == null)
            {
                throw new Exception();
            }
            int sum = 0;
            Node current = _head;
            Node tmp = new Node(0);
            tmp.Next = current;

            while (current != null)
            {
                if (current.Value == val)
                {
                    if (current == _head)
                    {
                        RemoveFirst();
                        sum += 1;
                    }
                    else if (current == _tail)
                    {
                        RemoveLast();
                        sum += 1;
                    }
                    else
                    {
                        tmp.Next = current.Next;
                        sum += 1;
                    }
                }
                tmp = current;
                current = current.Next;
            }
            return sum;
        }
        public bool Contains(int val) //- проверка, есть ли элемент в списке
        {
            Node current = _head;
            while (current.Next != null)
            {
                if (current.Value == val)
                {
                    return true; ;
                }
                current = current.Next;
            }
            return false;

        }

        public int IndexOf(int val) //- вернёт индекс первого найденного элемента, равного val(или -1,
                                    //если элементов с таким значением в списке нет)
        {
            int counter = 0;
            Node current = _head;
            while (current.Next != null)
            {
                if (current.Value == val)
                    return counter;
                if (current.Next == null)
                    return -1;
                current = current.Next;
                counter++;
            }
            return counter;
        }
        public int GetFirst() //вернёт значение первого элемента списка
        {
            Node current = _head;
            return current.Value;
        }
        public int GetLast() //- вернёт значение последнего элемента списка
        {
            Node current = _tail;
            return current.Value;
        }

        public int Get(int idx)// - вернёт значение элемента списка c указанным индексом
        {
            Node current = _head;
            int counter = 0;
            while (current.Next != null)
            {
                if (counter == idx)
                    break;
                if (current.Next == null)
                    throw new IndexOutOfRangeException("индекс больше количества элементов");
                counter++;
                current = current.Next;
            }
            return current.Value;
        }

        //Reverse() - изменение порядка элементов списка на обратный
        public void Reverse()
        {
            Node previous = null;
            Node current = _head;
            Node temp;
            while (current != null)
            {
                temp = current.Next;
                current.Next = previous;
                previous = current;
                current = temp;
            }
            _head = previous;
        }

        //Max() - поиск значения максимального элемента
        public int Max()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }
            if (_head.Next == null)
            {
                return _head.Value;
            }

            int max = _head.Value;
            Node current = _head;
            while (current.Next != null)
            {
                if (max < current.Value)
                    max = current.Value;
                current = current.Next;
            }
            return max;
        }
        public int Min() // - поиск минимального значения
        {

            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }
            if (_head.Next == null)
            {
                return _head.Value;
            }
            int min = _head.Value;
            Node current = _head;
            while (current.Next != null)
            {
                if (min > current.Value)
                    min = current.Value;
                current = current.Next;
            }
            return min;
        }

        
        public int IndexOfMax() //- поиск индекс максимального элемента
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }
            if (_head.Next == null)
            {
                return 0;
            }
            if (_head == null)
                return -1;
            int max = _head.Value;
            int counter = 0;
            int idxOfMax = 0;
            Node current = _head;
            while (current.Next != null)
            {
                if (max < current.Value)
                {
                    max = current.Value;
                    idxOfMax = counter;
                }
                counter++;
                current = current.Next;
            }
            return idxOfMax;
        }
       
        public int IndexOfMin()   // - поиск индекс минимального элемента
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }
            if (_head.Next == null)
            {
                return 0;
            }
            if (_head == null)
                return -1;
            int min = _head.Value;
            int counter = 0;
            int idxOfMin = 0;
            Node current = _head;
            while (current.Next != null)
            {
                if (min > current.Value)
                {
                    min = current.Value;
                    idxOfMin = counter;
                }
                counter++;
                current = current.Next;
            }
            return idxOfMin;
        }
        


        public void Sort() // - сортировка по возрастанию
        {
            if (_head == null)
                return;
            Node tempPrev, prev, tempCurrent, current, temp;

            tempPrev = prev = _head;
            while (prev.Next != null)
            {
                tempCurrent = current = prev.Next;
                while (current != null)
                {
                    if (prev.Value > current.Value)
                    {
                        if (prev.Next == current)
                        {
                            if (prev == _head)
                            {
                                prev.Next = current.Next;
                                current.Next = prev;
                                //swap:
                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                _head = prev;

                                current = current.Next;
                            }

                            else
                            {
                                prev.Next = current.Next;
                                current.Next = prev;
                                tempPrev.Next = current;
                                // Swap
                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                current = current.Next;
                            }
                        }
                        else
                        {
                            if (prev == _head)
                            {
                                temp = prev.Next;
                                prev.Next = current.Next;
                                current.Next = temp;
                                tempCurrent.Next = prev;

                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                current = current.Next;

                                _head = prev;
                            }

                            // prev != _head
                            else
                            {
                                temp = prev.Next;
                                prev.Next = current.Next;
                                current.Next = temp;
                                tempCurrent.Next = prev;
                                tempPrev.Next = current;

                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                current = current.Next;
                            }
                        }
                    }
                    else
                    {
                        tempCurrent = current;
                        current = current.Next;
                    }
                }
                tempPrev = prev;
                prev = prev.Next;
            }
            _tail = _head;
            while (_tail.Next != null)
                _tail = _tail.Next;
        }

        
        public void SortDesc() // - сортировка по убыванию
        {
            if (_head == null)
                return;
            Node tempPrev, prev, tempCurrent, current, temp;

            tempPrev = prev = _head;
            while (prev.Next != null)
            {
                tempCurrent = current = prev.Next;
                while (current != null)
                {
                    if (prev.Value < current.Value)
                    {
                        if (prev.Next == current)
                        {
                            if (prev == _head)
                            {
                                prev.Next = current.Next;
                                current.Next = prev;
                                //swap:
                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                _head = prev;

                                current = current.Next;
                            }

                            else
                            {
                                prev.Next = current.Next;
                                current.Next = prev;
                                tempPrev.Next = current;
                                // Swap
                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                current = current.Next;
                            }
                        }
                        else
                        {
                            if (prev == _head)
                            {
                                temp = prev.Next;
                                prev.Next = current.Next;
                                current.Next = temp;
                                tempCurrent.Next = prev;

                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                current = current.Next;

                                _head = prev;
                            }

                            // prev != _head
                            else
                            {
                                temp = prev.Next;
                                prev.Next = current.Next;
                                current.Next = temp;
                                tempCurrent.Next = prev;
                                tempPrev.Next = current;

                                temp = prev;
                                prev = current;
                                current = temp;

                                tempCurrent = current;

                                current = current.Next;
                            }
                        }
                    }
                    else
                    {
                        tempCurrent = current;
                        current = current.Next;
                    }
                }
                tempPrev = prev;
                prev = prev.Next;
            }
            _tail = _head;
            while (_tail.Next != null)
                _tail = _tail.Next;
        }
    }
}
