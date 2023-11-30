using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSumNech()
        {
            //передаем параметры, как на ввод в переменную value
            double[] vec = new[] { 1, -2, 3, 1, -4, -5, 11, -38.5, -1 };

            //создаем переменную result для рассчетов = namespace.classname.methodName(value)
            var sum = Laba1.Program.SumNechEl(vec);

            //  Assert.Equal(neaded_result, result);
            Assert.AreEqual(-44.5, sum);
        }

        [TestMethod]
        public void TestMethodSumma()
        {
            double[] vec = new[] { 1, -2, 3, 1, -4, -5, 11, -38.5, -1 };
            var sum = Laba1.Program.SumBetwinNeg(vec);
            Assert.AreEqual(-32.5, sum);
        }

        [TestMethod]
        public void TestMethodDellitingOnes()
        {
            double[] vec = new[] { 1, -2, 3, 1, -4, -5, 11, -38.5, -1 };
            var newArr = Laba1.Program.DelOne(vec);
            double[] _vec = new[] { -2, 3, -4, -5, 11, -38.5, 0, 0, 0 };
            Assert.AreEqual(newArr, _vec);
        }

        [TestMethod]
        public void TestMethodSummaX()
        {
            int[,] __SquarArr = new int[4, 4] { { 1, -2, 3, 0 }, { -4, -5, 11, -38 }, { 5, -4, 88, -3 }, { 0, -1, 18, -30 } };
            int[] __helper = new int[6];
            var sum = Laba1.Program.MaxSummX(__SquarArr, __helper);
            Assert.AreEqual(10, sum);
        }
    }
}
