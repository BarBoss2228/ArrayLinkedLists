using LinkedList;
using NUnit.Framework;

namespace LinkedListTests
{
    public class Tests
    {
        private LL _linkedlist;
        [SetUp]
        public void Setup()
        {
            _linkedlist = new LL();
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 7)]
        public void GetLengthTest(int[] array, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.GetLength();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 1, 2, 3 }, new int[] { 1, 2, 3 }, 5)]
        [TestCase(new int[] { 0 }, new int[] { }, 0)]
        public void AddFirstTest(int[] array, int[] array2, int value)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            //act
            temp.AddFirst(value);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 })]
        public void AddFirstTest2(int[] array, int[] array2, int[] array3)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            LL temp3 = new LL(array3);
            //act
            temp.AddFirst(temp3);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 }, 4)]
        [TestCase(new int[] { 0 }, new int[] { }, 0)]
        public void AddLastTest(int[] array, int[] array2, int value)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            //act
            temp.AddLast(value);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 8, 9, 10 }, new int[] { 1, 2, 3 }, new int[] { 8, 9, 10 })]
        public void AddLastTest2(int[] array, int[] array2, int[] array3)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            LL temp3 = new LL(array3);
            //act
            temp.AddLast(temp3);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 5, 3, 9 }, new int[] { 1, 2, 3, 9 }, 2, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, 0, 1)] //- не могу понять, в какой момент сваливается тест...
        public void AddAtTest(int[] array, int[] array2, int index, int value)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            //act
            temp.AddAt(index, value);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 11, 20, 3, 3, 9 }, new int[] { 1, 2, 3, 9 }, new int[] { 11, 20, 3 }, 2)]
        public void AddAtTest2(int[] array, int[] array2, int[] array3, int index)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            LL temp3 = new LL(array3);
            //act
            temp.AddAt(index, temp3);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, new int[] { 1, 2, 3, 9 }, 1, 77)]
        [TestCase(new int[] { 1, 2, 3, 77 }, new int[] { 1, 2, 3, 9 }, 3, 77)]
        [TestCase(new int[] { 1, 2, 3, 5, 77, 8 }, new int[] { 1, 2, 3, 5, 6, 8 }, 4, 77)]
        public void SetTest(int[] array, int[] array2, int index, int value)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            //act
            temp.Set(index, value);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 9 }, new int[] { })]
        public void RemoveFirstTest(int[] array, int[] array2)
        {
            //arrange
            LL temp = new LL(array);
            LL temp2 = new LL(array2);
            //act
            temp.RemoveFirst();
            int[] expected = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 9 }, new int[] { })]
        public void RemoveLastTest(int[] array, int[] array2)
        {
            //arrange
            LL temp = new LL(array);
            LL temp2 = new LL(array2);
            //act
            temp.RemoveLast();
            int[] expected = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 1, 2, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8 }, new int[] { 9, 1, 2, 3, 8, 9 }, 5)]
        public void RemoveAtTest(int[] array, int[] array2, int idx)
        {
            //arrange
            LL temp = new LL(array);
            LL temp2 = new LL(array2);
            //act
            temp2.RemoveAt(idx);
            int[] expected = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
        [TestCase(new int[] { }, new int[] { 9, 1, 2, 3, 8, 9 }, 6)]
        public void RemoveFirstMultipleTest(int[] array, int[] array2, int n)
        {
            //arrange
            LL temp = new LL(array);
            LL temp2 = new LL(array2);
            //act
            temp2.RemoveFirstMultiple(n);
            int[] expected = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 1, 2 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
        [TestCase(new int[] { }, new int[] { 9, 1, 2, 3, 8, 9 }, 6)]
        public void RemoveLastMultipleTest(int[] array, int[] array2, int n)
        {
            //arrange
            LL temp = new LL(array);
            LL temp2 = new LL(array2);
            //act
            temp2.RemoveLastMultiple(n);
            int[] expected = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 9 }, new int[] { 1, 2, 3, 9 }, 1, 2)]
        public void RemoveAtMultipleTest(int[] array, int[] array2, int index, int value)
        {
            //arrange
            LL temp2 = new LL(array);
            LL temp = new LL(array2);
            //act
            temp.RemoveAtMultiple(index, value);
            int[] expected = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 11)]
        [TestCase(new int[] { 1, 77, 3, 9 }, 4)]
        [TestCase(new int[] { }, 0)]
        public void RemoveAtNegativeTest2(int[] array, int index)
        {
            //arrange
            LL temp = new LL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.RemoveAt(index));
        }

        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, 2)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, 0)]
        [TestCase(new int[] { 4, 4 }, 4, 2)]
        public void RemoveAllTest(int[] array, int val, int expected)
        {
            //arrange

            LL temp = new LL(array);
            //act                      
            int actual = temp.RemoveAll(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, true)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, false)]
        public void ContainsTest(int[] array, int val, bool expected)
        {
            //arrange

            LL temp = new LL(array);
            //act                      
            bool actual = temp.Contains(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9)]
        public void GetFirstTest(int[] array, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.GetFirst();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 3, 2)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, 9)]
        [TestCase(new int[] { 7, 1, 2, 3, 8, 9 }, 0, 7)]
        public void GetTest(int[] array, int index, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.Get(index);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 9, 8, 3, 2, 1, 9 }, new int[] { 9, 1, 2, 3, 8, 9 })]
        public void ReverseTest(int[] array, int[] array2)
        {
            //arrange
            LL temp = new LL(array);
            LL temp2 = new LL(array2);
            //act
            temp2.Reverse();
            int[] expected = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 4)]
        [TestCase(new int[] { 9 }, 9)]
        public void MaxTest(int[] array, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.Max();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void MaxNegativeTest(int[] array, int index)
        {
            //arrange
            LL temp = new LL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Max());
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9, 11 }, 1)]
        [TestCase(new int[] { 9 }, 9)]
        public void MinTest(int[] array, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.Min();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void MinNegativeTest(int[] array, int index)
        {
            //arrange
            LL temp = new LL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Min());
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 1)]
        [TestCase(new int[] { 9 }, 0)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.IndexOfMax();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void IndexOfMaxNegativeTest(int[] array, int index)
        {
            //arrange
            LL temp = new LL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.IndexOfMax());
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
        [TestCase(new int[] { 9, 1, -5, 2, 3, 8, 9, 11 }, 2)]
        [TestCase(new int[] { 9 }, 0)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            //arrange           
            LL temp = new LL(array);
            //act            
            int actual = temp.IndexOfMin();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void IndexOfMinNegativeTest(int[] array, int index)
        {
            //arrange
            LL temp = new LL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.IndexOfMin());
        }
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 11, 8, 3, 5 }, new int[] { 3, 5, 8, 11 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 42 }, new int[] { 42 })]

        public void SortTest(int[] arr, int[] expected)
        {
            LL list = new LL(arr);

            list.Sort();
            var actual = list.ToArray();

            Assert.AreEqual(actual, expected);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 3, 5, 8, 11 }, new int[] { 11, 8, 5, 3 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 42 }, new int[] { 42 })]

        public void SortDesc(int[] arr, int[] expected)
        {
            LL list = new LL(arr);

            list.SortDesc();
            var actual = list.ToArray();

            Assert.AreEqual(actual, expected);
        }

    }
}
    


