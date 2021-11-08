using NUnit.Framework;
using ArrayLists;

namespace ArrayListsTests
{
    public class ALTests
    {
        private AL _arrayLists;
        [SetUp]
        public void Setup()
        {
            _arrayLists = new AL();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { }, 0)]
        public void GetLengthTest(int[] array, int expected)
        {
            //arrange           
            AL temp = new AL(array);
            //act            
            int actual = temp.GetLength();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 1, 2, 3 }, 9)]
        [TestCase(new int[] { 0 }, new int[] { }, 0)]
        public void AddFirstTest(int[] array, int[] array2, int value)
        {
            //arrange
            AL temp2 = new AL(array);
            AL temp = new AL(array2);
            //act
            temp.AddFirst(value);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        public void RemoveFirstTest(int[] array1, int[] array2)
        {
            //arrange
            AL newArray1 = new AL(array1);
            AL newArray2 = new AL(array2);
            //act
            newArray1.RemoveFirst();
            int[] actual = newArray1.ToArray();
            int[] expected = newArray2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 },new int [] {1, 2, 3, 4})]
        public void RemoveLastTest(int[] array1, int[] array2)
        {
            //arrange
            AL newArray1 = new AL(array1);
            AL newArray2 = new AL(array2);
            //act
            newArray1.RemoveLast();
            int[] actual = newArray1.ToArray();
            int[] expected = newArray2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2,new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 4, 5})]
        public void RemoveAtTest(int idx, int[] array1, int[] array2)
        {
            //arrange
            AL newArray1 = new AL(array1);
            AL newArray2 = new AL(array2);
            //act
            newArray1.RemoveAt(2);
            int[] actual = newArray1.ToArray();
            int[] expected = newArray2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5})]
        public void RemoveFirstMultipleTest(int n, int[] array1, int[] array2)
        {
            //arrange
            AL newArray1 = new AL(array1);
            AL newArray2 = new AL(array2);
            //act
            newArray1.RemoveFirstMultiple(2);
            int[] actual = newArray1.ToArray();
            int[] expected = newArray2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 })]
        public void RemoveLastMultipleTest(int n, int[] array1, int[] array2)
        {
            //arrange
            AL newArray1 = new AL(array1);
            AL newArray2 = new AL(array2);
            //act
            newArray1.RemoveLastMultiple(2);
            int[] actual = newArray1.ToArray();
            int[] expected = newArray2.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, 5, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3 })]
        [TestCase(0, 7, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 8 })]
        [TestCase(7, 1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void RemoveAtMultipleTest(int idx, int n, int[] array1, int[] array2)
        {
            //arrange
            AL actual = new AL(array1);
            AL expected = new AL(array2);
            //act
            actual.RemoveAtMultiple(idx,n);
           
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}