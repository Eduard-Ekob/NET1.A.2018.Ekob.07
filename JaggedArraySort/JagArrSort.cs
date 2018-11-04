using System;

namespace JaggedArraySort
{
    public static class JagArrSort
    {
        /// <summary>
        /// The BubbleSortSumElemInLine sort jagged array by sum elements in line of array
        /// </summary>
        /// <param name="jagArr">jagArr is incomming array for sort</param>
        /// <exception cref="ArgumentNullException">If incomming array is null</exception>
        public static void BubbleSortSumElemInLine(int[][] jagArr)
        {
            if (jagArr == null)
            {
                throw new ArgumentNullException(nameof(jagArr));
            }

            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = i + 1; j < jagArr.Length; j++)
                {
                    if (jagArr[j] == null )
                    {
                        //Swap(ref jagArr[i], ref jagArr[j]);
                        continue;
                    }

                    if (SumArrLine(ref jagArr[i]) < SumArrLine(ref jagArr[j]))
                    {
                        Swap(ref jagArr[i], ref jagArr[j]);
                    }
                }
            }
        }

        /// <summary>
        /// The SortMaxElemInLine sort jagged array with maximum element in line of array
        /// </summary>
        /// <param name="jagArr">jagArr is incomming array for sort</param>
        /// <exception cref="ArgumentNullException">If incomming array is null</exception>
        public static void SortMaxElemInLine(int[][] jagArr)
        {
            if (jagArr == null)
            {
                throw new ArgumentNullException(nameof(jagArr));
            }

            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = i + 1; j < jagArr.Length; j++)
                {
                    if (jagArr[i] == null)
                    {
                        Swap(ref jagArr[i], ref jagArr[j]);
                        continue;
                    }

                    if (jagArr[j] == null)
                    {
                       
                        continue;
                    }

                    if (MaxArrLine(ref jagArr[i]) < MaxArrLine(ref jagArr[j]))
                    {
                        Swap(ref jagArr[i], ref jagArr[j]);
                    }
                }
            }
        }

        /// <summary>
        /// The SortMinElemInLine sort jagged array with minimum element in line of array
        /// </summary>
        /// <param name="jagArr">jagArr is incomming array for sort</param>
        /// <exception cref="ArgumentNullException">If incomming array is null</exception>
        public static void SortMinElemInLine(int[][] jagArr)
        {
            if (jagArr == null)
            {
                throw new ArgumentNullException(nameof(jagArr));
            }

            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = i + 1; j < jagArr.Length; j++)
                {
                    if (jagArr[i] == null)
                    {
                        continue;
                    }

                    if (jagArr[j] == null)
                    {
                        Swap(ref jagArr[i], ref jagArr[j]);
                        continue;
                    }

                    if (MinArrLine(ref jagArr[i]) > MinArrLine(ref jagArr[j]))
                    {
                        Swap(ref jagArr[i], ref jagArr[j]);
                    }
                }
            }
        }

        private static void Swap(ref int[] arrF, ref int[] arrS)
        {
            var tempArr = arrF;
            arrF = arrS;
            arrS = tempArr;
        }

        private static int SumArrLine(ref int[] arr)
        {
            int sum = 0;
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

            return sum;
        }

        private static int MinArrLine(ref int[] arr)
        {
            int min = arr[0];
            var minInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {                
                if (min > arr[i])
                {
                    min = arr[i];
                    minInd = i;
                }
            }

            return arr[minInd];
        }

        private static int MaxArrLine(ref int[] arr)
        {
            int max = arr[0];
            var maxInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (max < arr[i])
                {
                    max = arr[i];
                    maxInd = i;
                }
            }

            return arr[maxInd];
        }
    }

}
