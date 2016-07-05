using System;
using NUnit.Framework;
using static Task03.Copy;

namespace Task03.NUnitTests
{
    public class CopyTests
    {
        [TestCase(15, 3, 3, 5, Result = 31)]
        [TestCase(15, 5, 5, 6, Result = 47)]
        [TestCase(-15, 5, 0, 1, Result = -15)]
        [TestCase(15, -5, 2, 5, Result = 47)]
        [TestCase(-15, -5, 7, 11, Result = -15)]
        public int CopyMethod_OK(int first, int second, int startPos, int endPos)
        {
            return CopyMethod(first, second, startPos, endPos);
        }

        [TestCase(15, 5, 5, 4, ExpectedException = typeof(ArgumentException))]
        public int CopyMethod_ArgumentException(int first, int second, int startPos, int endPos)
        {
            return CopyMethod(first, second, startPos, endPos);
        }

        [TestCase(15, 5, -9, 4, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(15, 5, 2, 31, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(15, 5, 31, 31, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(15, 5, -2, -1, ExpectedException = typeof(ArgumentOutOfRangeException))]
        public int CopyMethod_ArgumentOutOfRangeException(int first, int second, int startPos, int endPos)
        {
            return CopyMethod(first, second, startPos, endPos);
        }
    }
}
