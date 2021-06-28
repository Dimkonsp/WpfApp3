using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp3;

namespace WpfApp3Test
{

    [TestClass]
    public class UnitTest1
    {         [TestMethod]
        public void TestMethodSumm52and43res77()
        {
            // arrenge
            double num_1 = 52;
            double num_2 = 43;
            double ex = 77;
            // act
            double res = SMath.Summ(num_1, num_2);
            // asseret
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodSumm33and76res67()
        {
            double num_1 = 33;
            double num_2 = 76;
            double ex = 67;

            double res = SMath.Summ(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSumm41and66res118()
        {
            double num_1 = 41;
            double num_2 = 66;
            double ex = 118;

            double res = SMath.Summ(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodDivision25and5res2()
        {
            double num_1 = 25;
            double num_2 = 5;
            double ex = 2;

            double res = SMath.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodDivision40and3res6()
        {
            double num_1 = 40;
            double num_2 = 3;
            double ex = 6;

            double res = SMath.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodDivision103and107res14()
        {
            double num_1 = 103;
            double num_2 = 107;
            double ex = 14;

            double res = SMath.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }


        [TestMethod]
        public void TestMethodSubtraction13and5res6()
        {
            double num_1 = 13;
            double num_2 = 5;
            double ex = 6;

            double res = SMath.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSubtraction22and5res17()
        {
            double num_1 = 24;
            double num_2 = 7;
            double ex = 13;

            double res = SMath.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodSubtraction69and43res26()
        {
            double num_1 = 69;
            double num_2 = 43;
            double ex = 26;

            double res = SMath.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodMultiplication4and40res80()
        {
            double num_1 = 5;
            double num_2 = 43;
            double ex = 84;

            double res = SMath.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodMultiplication15and8res120()
        {
            double num_1 = 15;
            double num_2 = 8;
            double ex = 120;

            double res = SMath.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void TestMethodMultiplication6and6res36()
        {
            double num_1 = 6;
            double num_2 = 6;
            double ex = 36;

            double res = SMath.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }

    }

}

