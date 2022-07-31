using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp
{
    internal class NumberFromDecimalRepresentation
    {
        public int GetNumberFromDecimalArray(int[] A)
        {
            int multiple = 1;
            int number = 0;

            for(int i=0; i<A.Length; i++)
            {
                number += A[i] * multiple;
                multiple *= 10;
            }

            return number;
        }
    }
}
