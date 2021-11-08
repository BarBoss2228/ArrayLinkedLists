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
    }
}
