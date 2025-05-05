using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TestTaskByndyusoft;

namespace TestsForSumInArray
{
    [TestClass]
    public class MinSumCalculatorTests
    {
        [TestMethod]
        public void TestSumOfTwoMinNumbers_NormalCase_FirstFunction()
        {
            //arrange
            int[] array = { 4, 0, 3, 19, 492, -10, 1 };
            //act
            int result = Program.SumOfTwoLessElements(array);
            //assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void TestSumOfTwoMinNumbers_NormalCase_SecondFunction()
        {
            //arrange
            int[] array = { 4, 0, 3, 19, 492, -10, 1 };
            //act
            int result = Program.SumOfTwoMinNumbers(array);
            //assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSumOfTwoMinNumbers_EmptyArray_FirstFunction()
        {
            //arrange
            int[] array = Array.Empty<int>();
            //act
            int result = Program.SumOfTwoLessElements(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSumOfTwoMinNumbers_EmptyArray_SecondFunction()
        {
            //arrange
            int[] array = Array.Empty<int>();
            //act
            int result = Program.SumOfTwoMinNumbers(array);
        }

        [TestMethod]
        public void TestSumOfTwoMinNumbers_LargeArray_FirstFunction()
        {
            //arrange
            int?[] nullableArray = new int?[1000000];
            nullableArray[9962] = -100;
            nullableArray[100004] = -200;
            for(int i = 0; i < nullableArray.Length; i++)
            {
                if(nullableArray[i] != null)
                {
                    continue;
                }

                nullableArray[i] = i;
            }

            int[] array = nullableArray.Select(x => x.Value).ToArray();
            //act
            int result = Program.SumOfTwoLessElements(array);
            //assert
            Assert.AreEqual(-300, result);
        }

        [TestMethod]
        public void TestSumOfTwoMinNumbers_LargeArray_SecondFunction()
        {
            //arrange
            int?[] nullableArray = new int?[1000000];
            nullableArray[9962] = -100;
            nullableArray[100004] = -200;
            for (int i = 0; i < nullableArray.Length; i++)
            {
                if (nullableArray[i] != null)
                {
                    continue;
                }

                nullableArray[i] = i;
            }

            int[] array = nullableArray.Select(x => x.Value).ToArray();
            //act
            int result = Program.SumOfTwoMinNumbers(array);
            //assert
            Assert.AreEqual(-300, result);
        }
    }
}
