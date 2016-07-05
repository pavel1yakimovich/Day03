using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public static class Copy
    {
        private static int MaxBit = 30;
        /// <summary>
        /// method inserts first number in second. second number will be from startPos bit to endPos bit.
        /// </summary>
        /// <param name="first">number that we insert</param>
        /// <param name="second">number, we insert in</param>
        /// <param name="startPos">start number of bit</param>
        /// <param name="endPos">end number of bit</param>
        /// <returns>inserted number</returns>
        public static int CopyMethod(int first, int second, int startPos, int endPos)
        {
            if (startPos < 0 || endPos > MaxBit)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (startPos > endPos)
            {
                throw new ArgumentException();
            }

            int k = (int) (Math.Pow(2, endPos - startPos + 1) - 1);
            second = second & k;
            second = second << startPos;

            return first | second;
        }
    }
}
