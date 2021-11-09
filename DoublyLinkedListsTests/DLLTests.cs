using DoublyLinkedLists;
using NUnit.Framework;

namespace DoublyLinkedListsTests
{
    public class Tests
    {
        private DLL _doublyLinkedLists;
     
        [SetUp]
        public void Setup()
        {
            _doublyLinkedLists = new DLL();
        }
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { }, 0)]
        public void GetLengthTest(int[] array, int exception)
        {
            //arrange
           DLL temp = new DLL(array);
            //act
            int actual = temp.GetLength();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 1, 2, 3 }, 9)]
        [TestCase(new int[] { 0 }, new int[] { }, 0)]
        public void AddFirstTest(int[] array, int[] array2, int value)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
            //act
            temp.AddFirst(value);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 9 }, new int[] { 1, 2, 3 }, 9)]
        [TestCase(new int[] { 0 }, new int[] { }, 0)]
        public void AddLastTest(int[] array, int[] array2, int value)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
            //act
            temp.AddLast(value);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 11, 20, 3, 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 11, 20, 3 })]
        public void AddFirstTest2(int[] array, int[] array2, int[] array3)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
           DLL temp3 = new DLL(array3);
            //act
            temp.AddFirst(temp3);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 11, 20, 3 }, new int[] { 1, 2, 3 }, new int[] { 11, 20, 3 })]
        public void AddLastTest2(int[] array, int[] array2, int[] array3)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
           DLL temp3 = new DLL(array3);
            //act
            temp.AddLast(temp3);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 2, 5, 3, 9 }, new int[] { 1, 2, 3, 9 }, 2, 5)]
        public void AddAtTest(int[] array, int[] array2, int index, int value)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
            //act
            temp.AddAt(index, value);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 11, 11)]
        public void AddAtNegativeTest(int[] array, int index, int value)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.AddAt(index, value));
        }
        [TestCase(new int[] { 1, 2, 11, 20, 3, 3, 9 }, new int[] { 1, 2, 3, 9 }, new int[] { 11, 20, 3 }, 2)]
        public void AddAtTest2(int[] array, int[] array2, int[] array3, int index)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
           DLL temp3 = new DLL(array3);
            //act
            temp.AddAt(index, temp3);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 9 }, new int[] { 11, 20, 3 }, 5)]
        public void AddAtNegativeTest2(int[] array, int[] array2, int index)
        {
            //arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.AddAt(index, temp2));
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, new int[] { 1, 2, 3, 9 }, 1, 77)]
        [TestCase(new int[] { 1, 2, 3, 77 }, new int[] { 1, 2, 3, 9 }, 3, 77)]
        [TestCase(new int[] { 1, 2, 3, 5, 77, 8 }, new int[] { 1, 2, 3, 5, 6, 8 }, 4, 77)]
        public void SetTest(int[] array, int[] array2, int index, int value)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
            //act
            temp.Set(index, value);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 11, 11)]
        public void SetNegativeTest(int[] array, int index, int value)
        {
            //arrange
           DLL temp = new DLL(array);
            // act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Set(index, value));
        }

        [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 9 }, new int[] { })]
        public void RemoveFirstTest(int[] array, int[] array2)
        {
            //arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //act
            temp.RemoveFirst();
            int[] exception = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { })]
        public void RemoveFirstNegativeTest(int[] array)
        {
            //arrange
           DLL temp = new DLL(array);
            //act                    
            //assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.RemoveFirst());
        }
        [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 9, 1, 2 })]
        [TestCase(new int[] { 9 }, new int[] { })]
        public void RemoveLastTest(int[] array, int[] array2)
        {
            //arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //act
            temp.RemoveLast();
            int[] exception = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { })]
        public void RemoveLastNegativeTest(int[] array)
        {
            //arrange
           DLL temp = new DLL(array);
            //act                    
            //assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.RemoveFirst());
        }
        [TestCase(new int[] { 9, 1, 2, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8 }, new int[] { 9, 1, 2, 3, 8, 9 }, 5)]
        public void RemoveAtTest(int[] array, int[] array2, int idx)
        {
            //arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //act
            temp2.RemoveAt(idx);
            int[] exception = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 11)]
        [TestCase(new int[] { 1, 77, 3, 9 }, 4)]
        [TestCase(new int[] { }, 0)]
        public void RemoveAtNegativeTest(int[] array, int index)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.RemoveAt(index));
        }
        [TestCase(new int[] { 3, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
        [TestCase(new int[] { }, new int[] { 9, 1, 2, 3, 8, 9 }, 6)]
        public void RemoveFirstMultipleTest(int[] array, int[] array2, int n)
        {
            //arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //act
            temp2.RemoveFirstMultiple(n);
            int[] exception = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 5)]
        [TestCase(new int[] { }, 0)]
        public void RemoveFirstMultipleNegativeTest(int[] array, int n)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.Exception), () => temp.RemoveFirstMultiple(n));
        }
        [TestCase(new int[] { 9, 1, 2 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
        [TestCase(new int[] { }, new int[] { 9, 1, 2, 3, 8, 9 }, 6)]
        public void RemoveLastMultipleTest(int[] array, int[] array2, int n)
        {
            //arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //act
            temp2.RemoveLastMultiple(n);
            int[] exception = temp.ToArray();
            int[] actual = temp2.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 5)]
        [TestCase(new int[] { }, 0)]
        public void RemoveLastMultipleNegativeTest(int[] array, int n)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.Exception), () => temp.RemoveLastMultiple(n));
        }
        [TestCase(new int[] { 1, 9 }, new int[] { 1, 2, 3, 9 }, 1, 2)]
        public void RemoveAtMultipleTest(int[] array, int[] array2, int index, int value)
        {
            //arrange
           DLL temp2 = new DLL(array);
           DLL temp = new DLL(array2);
            //act
            temp.RemoveAtMultiple(index, value);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 5, 2)]
        [TestCase(new int[] { 1, 77, 3, 9 }, 1, 4)]
        [TestCase(new int[] { }, 0, 3)]
        public void RemoveAtMultipleNegativeTest(int[] array, int index, int n)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.Exception), () => temp.RemoveAtMultiple(index, n));
        }
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 3, 3)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, -1)]
        [TestCase(new int[] { 9 }, 9, 0)]
        public void RemoveFirstTest2(int[] array, int val, int exception)
        {
            //arrange

           DLL temp = new DLL(array);
            //act                      
            int actual = temp.RemoveFirst(val);
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { }, 0)]
        public void RemoveFirstNegativeTest2(int[] array, int n)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.Exception), () => temp.RemoveFirst(n));
        }
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, 2)]
        [TestCase(new int[] { 9, 1, 2, 9, 3, 8, 9 }, 9, 3)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, 0)]
        [TestCase(new int[] { 3, 3, 3 }, 3, 3)]
        public void RemoveAllTest(int[] array, int val, int exception)
        {
            //arrange
           DLL temp = new DLL(array);
            //act                      
            int actual = temp.RemoveAll(val);
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { }, 0)]
        public void RemoveAllNegativeTest(int[] array, int n)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.Exception), () => temp.RemoveAll(n));
        }
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, true)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, false)]
        public void ContainsTest(int[] array, int val, bool exception)
        {
            //arrange

           DLL temp = new DLL(array);
            //act                      
            bool actual = temp.Contains(val);
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, -1)]
        [TestCase(new int[] { }, 5, -1)]
        public void IndexOfTest(int[] array, int val, int exception)
        {
            //arrange

           DLL temp = new DLL(array);
            //act                      
            int actual = temp.IndexOf(val);
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9)]
        public void GetFirstTest(int[] array, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.GetFirst();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 3)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9)]
        public void GetLastTest(int[] array, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.GetLast();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 3, 2)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, 9)]
        [TestCase(new int[] { 7, 1, 2, 3, 8, 9 }, 0, 7)]
        public void GetTest(int[] array, int index, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.Get(index);
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { 1, 77, 3, 9 }, 11)]
        [TestCase(new int[] { }, 11)]
        public void GetNegativeTest(int[] array, int index)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Get(index));
        }

        [TestCase(new int[] { 34, 67, 100, 3, 2, 201 }, 201)]
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 4)]
        [TestCase(new int[] { 9 }, 9)]
        public void MaxTest(int[] array, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.Max();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void MaxNegativeTest(int[] array, int index)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Max());
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9, 11 }, 1)]
        [TestCase(new int[] { 9 }, 9)]
        public void MinTest(int[] array, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.Min();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void MinNegativeTest(int[] array, int index)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Min());
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 1)]
        [TestCase(new int[] { 9, 1, 2, 3, 8, 9, 11 }, 6)]
        [TestCase(new int[] { 9 }, 0)]
        public void IndexOfMaxTest(int[] array, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.IndexOfMax();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void IndexOfMaxNegativeTest(int[] array, int index)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.IndexOfMax());
        }
        [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
        [TestCase(new int[] { 9, 1, -5, 2, 3, 8, 9, 11 }, 2)]
        [TestCase(new int[] { 9 }, 0)]
        public void IndexOfMinTest(int[] array, int exception)
        {
            //arrange           
           DLL temp = new DLL(array);
            //act            
            int actual = temp.IndexOfMin();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [TestCase(new int[] { }, 11)]
        public void IndexOfMinNegativeTest(int[] array, int index)
        {
            //arrange
           DLL temp = new DLL(array);
            //act, assert
            Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.IndexOfMin());
        }
        [TestCase(new int[] { 9, 8, 3, 2, 1, 9 }, new int[] { 9, 1, 2, 3, 8, 9 })]
        public void ReverseTest(int[] array, int[] array2)
        {
            // arrange
           DLL temp = new DLL(array);
           DLL temp2 = new DLL(array2);
            //  act
            temp2.Reverse();
            int[] exception = temp.ToArray();
            int[] actual = temp2.ToArray();
            //  assert
            Assert.AreEqual(exception, actual);
        }
    }
}