using JaggedArraySort;
using NUnit.Framework;
using System;

namespace JaggedArraySortTests
{
    [TestFixture]
    public class JaggArrSortTest
    {
        [Test]
        public void BubbleSortOfIncreasingSumElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] InputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] ExpectedJagArr = new int[][]
            {
                new int[] {1, 48},
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {1, 1, 1, 21},
                new int[] {0, 2, 4, 6},
                null,
                null
            };

            // Act
            JagArrSort.BubbleSortOfIncreasingSumElemInLine(InputJagArr);

            // Assert
            CollectionAssert.AreEqual(ExpectedJagArr, InputJagArr);
        }
        [Test]
        public void BubbleSortOfDecreasingSumElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] InputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] ExpectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {0, 2, 4, 6},
                new int[] {1, 1, 1, 21},
                new int[] {1, 3, 5, 7, 9},
                new int[] {11, 22},
                new int[] {1, 48}
            };

            // Act
            JagArrSort.BubbleSortOfDecreasingSumElemInLine(InputJagArr);

            // Assert
            CollectionAssert.AreEqual(ExpectedJagArr, InputJagArr);
        }

        [Test]
        public void SortOfIncreasingMaxElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                null,
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 9952}
            };

            int[][] expectedJagArr = new int[][]
            {
                new int[] {1, 1, 1, 9952},
                new int[] {1, 48},
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                null,
                null
            };

            // Act
            JagArrSort.SortOfIncreasingMaxElemInLine(inputJagArr);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void SortOfIncreasingMinElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {-11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] expectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {-11, 22},
                new int[] {0, 2, 4, 6},
                new int[] {1, 3, 5, 7, 9},
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}

            };

            // Act
            JagArrSort.SortOfIncreasingMinElemInLine(inputJagArr);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }
        public void SortOfDecreasingMaxElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                null,
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 9952}
            };

            int[][] expectedJagArr = new int[][]
            {                                                              
                new int[] {0, 2, 4, 6},
                new int[] {1, 3, 5, 7, 9},
                new int[] {11, 22},
                new int[] {1, 48},
                new int[] {1, 1, 1, 9952},
                null,
                null
            };

            // Act
            JagArrSort.SortOfDecreasingMaxElemInLine(inputJagArr);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void SortOfDecreasingMinElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {-11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] expectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {1, 3, 5, 7, 9},                
                new int[] {1, 48},
                new int[] {1, 1, 1, 21},
                new int[] {0, 2, 4, 6},
                new int[] {-11, 22}
            };

            // Act
            JagArrSort.SortOfDecreasingMinElemInLine(inputJagArr);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void BubbleSortSumElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => JagArrSort.BubbleSortOfIncreasingSumElemInLine(null));

        [Test]
        public void BubbleSortMaxElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => JagArrSort.SortOfIncreasingMaxElemInLine(null));

        [Test]
        public void BubbleSortMinElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => JagArrSort.SortOfIncreasingMinElemInLine(null));
    }
}
