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
    }
    

}
