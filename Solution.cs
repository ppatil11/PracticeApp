using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp
{
    public class Solution
    {

        public int solutions(int[] A)
        {

            // int missing = findMissing(A, A.Length);

            int longestSpike = longSpike(A);

            return longestSpike;
        }

        private static int longSpike(int[] arr)
        {
           
            var lis = getLongestIncreasingSeq(arr);
     
            var lds = getLongestDecSeq(arr);

            return getLengthOfLogestSpike(arr.Length, lis, lds);
        }

        private static int[] getLongestIncreasingSeq(int[] arr)
        {
            int n = arr.Length;
            int[] lis = new int[n];
            for (int i = 0; i < n; i++)
            {
                lis[i] = 1;
                for (int j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] <= lis[j])
                        lis[i] = lis[j] + 1;
            }
            return lis;
        }

        private static int[] getLongestDecSeq(int[] arr)
        {
            int n = arr.Length;
            int[] lds = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                lds[i] = 1;
                for (int j = n - 1; j > i; j--)
                    if (arr[i] > arr[j] && lds[i] <= lds[j])
                        lds[i] = lds[j] + 1;
            }
            return lds;
        }

        private static int getLengthOfLogestSpike(int n, int[] lis, int[] lds)
        {
            int longestSpikeLen;
            longestSpikeLen = lis[0] + lds[0] - 1;
            for (int i = 1; i < n; i++)
            {
                if (lis[i] + lds[i] - 1 > longestSpikeLen)
                {
                    longestSpikeLen = lis[i] + lds[i] - 1;
                }
            }
            return longestSpikeLen;
        }

        static int segregate(int[] arr, int size)
        {
            int j = 0, i;
            for (i = 0; i < size; i++)
            {
                if (arr[i] <= 0)
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    // increment count of non-positive
                    // integers
                    j++;
                }
            }

            return j;
        }

        static int findMissing(int[] arr, int size)
        {

            // First separate positive and
            // negative numbers
            int shift = segregate(arr, size);
            int[] arr2 = new int[size - shift];
            int j = 0;

            for (int i = shift; i < size; i++)
            {
                arr2[j] = arr[i];
                j++;
            }

            // Shift the array and call
            // findMissingPositive for
            // positive part
            return findMissingPositive(arr2, j);
        }

        static int findMissingPositive(int[] arr, int size)
        {
            int i;

            // Mark arr[i] as visited by making
            // arr[arr[i] - 1] negative. Note that
            // 1 is subtracted as index start from
            // 0 and positive numbers start from 1
            //for (i = 0; i < size; i++)
           // {
            //    if (arr[i] - 1 < size && arr[arr[i] - 1] > 0)
            //        arr[arr[i] - 1] = -arr[arr[i] - 1];
            //}

           // arr.OrderByDescending(x => x).Reverse();
            Array.Sort(arr);
            int missingVal = 0;
            for(i = 0; i < size-1; i++)
            {
                int currentVal = arr[i];
                int nextVal = arr[i + 1];
                if (currentVal+1 != nextVal)
                {
                    missingVal = currentVal + 1;
                }

            }

            // Return the first index value at
            // which is positive
            //for (i = 0; i < size; i++)
            //    if (arr[i] > 0)
            //        return i + 1;

            // 1 is added because indexes
            // start from 0
            //return size + 1;

            return missingVal;
        }
    }
}
