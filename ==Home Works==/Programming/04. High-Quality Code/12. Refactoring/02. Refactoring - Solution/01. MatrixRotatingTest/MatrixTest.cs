using System;
using MatrixRotating;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixConstructorThrowsExceptionFirstTest()
        {
            Matrix matrix = new Matrix(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixConstructorThrowsExceptionSecondTest()
        {
            Matrix matrix = new Matrix(Matrix.MaxSize + 1);
        }

        [TestMethod]
        public void FirstMatrixTest()
        {
            Matrix matrix = new Matrix(1);

            matrix.Traverse();

            Assert.AreEqual("  1", matrix.ToString());
        }

        [TestMethod]
        public void SecondMatrixTest()
        {
            Matrix matrix = new Matrix(2);

            matrix.Traverse();

            Assert.AreEqual("  1  4\r\n  3  2", matrix.ToString());
        }

        [TestMethod]
        public void ThirdMatrixTest()
        {
            Matrix matrix = new Matrix(3);

            matrix.Traverse();

            Assert.AreEqual("  1  7  8\r\n  6  2  9\r\n  5  4  3", matrix.ToString());
        }

        [TestMethod]
        public void ForthMatrixTest()
        {
            Matrix matrix = new Matrix(6);

            matrix.Traverse();

            Assert.AreEqual(
                "  1 16 17 18 19 20\r\n" +
                " 15  2 27 28 29 21\r\n" +
                " 14 31  3 26 30 22\r\n" +
                " 13 36 32  4 25 23\r\n" +
                " 12 35 34 33  5 24\r\n" +
                " 11 10  9  8  7  6",
                matrix.ToString());
        }
    }
}
