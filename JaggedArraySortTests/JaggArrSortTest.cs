using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArraySort;

namespace JaggedArraySortTests
{
    [TestFixture]
    public class JaggArrSortTest
    {
        [Test]
        public void BubbleSortSumElemInLineTest_ReturnSortingArray()
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
            JagArrSort.BubbleSortSumElemInLine(InputJagArr);

            // Assert
            CollectionAssert.AreEqual(ExpectedJagArr, InputJagArr);
        }

        [Test]
        public void SortMaxElemInLineTest_ReturnSortingArray()
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
            JagArrSort.SortMaxElemInLine(inputJagArr);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void SortMinElemInLineTest_ReturnSortingArray()
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
            JagArrSort.SortMinElemInLine(inputJagArr);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void BubbleSortSumElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => JagArrSort.BubbleSortSumElemInLine(null));

        [Test]
        public void BubbleSortMaxElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => JagArrSort.SortMaxElemInLine(null));

        [Test]
        public void BubbleSortMinElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => JagArrSort.SortMinElemInLine(null));
    }
}
