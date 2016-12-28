namespace Base36Library.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Comparing
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Null()
        {
            Base36.Compare("ABC", null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Empty()
        {
            Base36.Compare("ABC", string.Empty);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Invalid()
        {
            Base36.Compare("ABC", "invali d");
        }

        [TestMethod]
        public void EqualPositive()
        {
            Assert.AreEqual(0, Base36.Compare("A", "A"));
            Assert.AreEqual(0, Base36.Compare("2S", "2S"));
            Assert.AreEqual(0, Base36.Compare("RS", "RS"));
            Assert.AreEqual(0, Base36.Compare("7PS", "7PS"));
            Assert.AreEqual(0, Base36.Compare("255S", "255S"));
            Assert.AreEqual(0, Base36.Compare("LFLS", "LFLS"));
            Assert.AreEqual(0, Base36.Compare("5YC1S", "5YC1S"));
            Assert.AreEqual(0, Base36.Compare("1NJCHS", "1NJCHS"));
            Assert.AreEqual(0, Base36.Compare("GJDGXS", "GJDGXS"));
            Assert.AreEqual(0, Base36.Compare("4LDQPDS", "4LDQPDS"));
            Assert.AreEqual(0, Base36.Compare("19XTF1TS", "19XTF1TS"));
            Assert.AreEqual(0, Base36.Compare("CRE66I9S", "CRE66I9S"));
            Assert.AreEqual(0, Base36.Compare("3JLXPT2PS", "3JLXPT2PS"));
            Assert.AreEqual(0, Base36.Compare("ZG3D62R5S", "ZG3D62R5S"));
            Assert.AreEqual(0, Base36.Compare("9UGXNORJLS", "9UGXNORJLS"));
            Assert.AreEqual(0, Base36.Compare("2QGPCKVNG1S", "2QGPCKVNG1S"));
            Assert.AreEqual(0, Base36.Compare("RCN1HSSIGHS", "RCN1HSSIGHS"));
            Assert.AreEqual(0, Base36.Compare("7LIEEXZX4KXS", "7LIEEXZX4KXS"));
        }

        [TestMethod]
        public void EqualNegative()
        {
            Assert.AreEqual(0, Base36.Compare("-A", "-A"));
            Assert.AreEqual(0, Base36.Compare("-2S", "-2S"));
            Assert.AreEqual(0, Base36.Compare("-RS", "-RS"));
            Assert.AreEqual(0, Base36.Compare("-7PS", "-7PS"));
            Assert.AreEqual(0, Base36.Compare("-255S", "-255S"));
            Assert.AreEqual(0, Base36.Compare("-LFLS", "-LFLS"));
            Assert.AreEqual(0, Base36.Compare("-5YC1S", "-5YC1S"));
            Assert.AreEqual(0, Base36.Compare("-1NJCHS", "-1NJCHS"));
            Assert.AreEqual(0, Base36.Compare("-GJDGXS", "-GJDGXS"));
            Assert.AreEqual(0, Base36.Compare("-4LDQPDS", "-4LDQPDS"));
            Assert.AreEqual(0, Base36.Compare("-19XTF1TS", "-19XTF1TS"));
            Assert.AreEqual(0, Base36.Compare("-CRE66I9S", "-CRE66I9S"));
            Assert.AreEqual(0, Base36.Compare("-3JLXPT2PS", "-3JLXPT2PS"));
            Assert.AreEqual(0, Base36.Compare("-ZG3D62R5S", "-ZG3D62R5S"));
            Assert.AreEqual(0, Base36.Compare("-9UGXNORJLS", "-9UGXNORJLS"));
            Assert.AreEqual(0, Base36.Compare("-2QGPCKVNG1S", "-2QGPCKVNG1S"));
            Assert.AreEqual(0, Base36.Compare("-RCN1HSSIGHS", "-RCN1HSSIGHS"));
            Assert.AreEqual(0, Base36.Compare("-7LIEEXZX4KXS", "-7LIEEXZX4KXS"));
        }

        [TestMethod]
        public void PositiveComparison()
        {
            Assert.AreEqual(1, Base36.Compare("A", "10"));
            Assert.AreEqual(1, Base36.Compare("RS", "100"));
            Assert.AreEqual(1, Base36.Compare("7PS", "1000"));
            Assert.AreEqual(1, Base36.Compare("LFLS", "10000"));
            Assert.AreEqual(1, Base36.Compare("5YC1S", "100000"));
            Assert.AreEqual(1, Base36.Compare("GJDGXS", "1000000"));
            Assert.AreEqual(1, Base36.Compare("4LDQPDS", "10000000"));
            Assert.AreEqual(1, Base36.Compare("CRE66I9S", "100000000"));
            Assert.AreEqual(1, Base36.Compare("ZG3D62R5S", "1000000000"));
            Assert.AreEqual(1, Base36.Compare("9UGXNORJLS", "10000000000"));
            Assert.AreEqual(1, Base36.Compare("RCN1HSSIGHS", "100000000000"));

            Assert.AreEqual(-1, Base36.Compare("10", "A"));
            Assert.AreEqual(-1, Base36.Compare("100", "RS"));
            Assert.AreEqual(-1, Base36.Compare("1000", "7PS"));
            Assert.AreEqual(-1, Base36.Compare("10000", "LFLS"));
            Assert.AreEqual(-1, Base36.Compare("100000", "5YC1S"));
            Assert.AreEqual(-1, Base36.Compare("1000000", "GJDGXS"));
            Assert.AreEqual(-1, Base36.Compare("10000000", "4LDQPDS"));
            Assert.AreEqual(-1, Base36.Compare("100000000", "CRE66I9S"));
            Assert.AreEqual(-1, Base36.Compare("1000000000", "ZG3D62R5S"));
            Assert.AreEqual(-1, Base36.Compare("10000000000", "9UGXNORJLS"));
            Assert.AreEqual(-1, Base36.Compare("100000000000", "RCN1HSSIGHS"));
        }

        [TestMethod]
        public void NegativeComparison()
        {
            Assert.AreEqual(-1, Base36.Compare("-A", "-10"));
            Assert.AreEqual(-1, Base36.Compare("-RS", "-100"));
            Assert.AreEqual(-1, Base36.Compare("-7PS", "-1000"));
            Assert.AreEqual(-1, Base36.Compare("-LFLS", "-10000"));
            Assert.AreEqual(-1, Base36.Compare("-5YC1S", "-100000"));
            Assert.AreEqual(-1, Base36.Compare("-GJDGXS", "-1000000"));
            Assert.AreEqual(-1, Base36.Compare("-4LDQPDS", "-10000000"));
            Assert.AreEqual(-1, Base36.Compare("-CRE66I9S", "-100000000"));
            Assert.AreEqual(-1, Base36.Compare("-ZG3D62R5S", "-1000000000"));
            Assert.AreEqual(-1, Base36.Compare("-9UGXNORJLS", "-10000000000"));
            Assert.AreEqual(-1, Base36.Compare("-RCN1HSSIGHS", "-100000000000"));

            Assert.AreEqual(1, Base36.Compare("-10", "-A"));
            Assert.AreEqual(1, Base36.Compare("-100", "-RS"));
            Assert.AreEqual(1, Base36.Compare("-1000", "-7PS"));
            Assert.AreEqual(1, Base36.Compare("-10000", "-LFLS"));
            Assert.AreEqual(1, Base36.Compare("-100000", "-5YC1S"));
            Assert.AreEqual(1, Base36.Compare("-1000000", "-GJDGXS"));
            Assert.AreEqual(1, Base36.Compare("-10000000", "-4LDQPDS"));
            Assert.AreEqual(1, Base36.Compare("-100000000", "-CRE66I9S"));
            Assert.AreEqual(1, Base36.Compare("-1000000000", "-ZG3D62R5S"));
            Assert.AreEqual(1, Base36.Compare("-10000000000", "-9UGXNORJLS"));
            Assert.AreEqual(1, Base36.Compare("-100000000000", "-RCN1HSSIGHS"));
        }

        [TestMethod]
        public void PositiveAndNegativeComparison()
        {
            Assert.AreEqual(1, Base36.Compare("-A", "10"));
            Assert.AreEqual(1, Base36.Compare("-RS", "100"));
            Assert.AreEqual(1, Base36.Compare("-7PS", "1000"));
            Assert.AreEqual(1, Base36.Compare("-LFLS", "10000"));
            Assert.AreEqual(1, Base36.Compare("-5YC1S", "100000"));
            Assert.AreEqual(1, Base36.Compare("-GJDGXS", "1000000"));
            Assert.AreEqual(1, Base36.Compare("-4LDQPDS", "10000000"));
            Assert.AreEqual(1, Base36.Compare("-CRE66I9S", "100000000"));
            Assert.AreEqual(1, Base36.Compare("-ZG3D62R5S", "1000000000"));
            Assert.AreEqual(1, Base36.Compare("-9UGXNORJLS", "10000000000"));
            Assert.AreEqual(1, Base36.Compare("-RCN1HSSIGHS", "100000000000"));

            Assert.AreEqual(1, Base36.Compare("-10", "A"));
            Assert.AreEqual(1, Base36.Compare("-100", "RS"));
            Assert.AreEqual(1, Base36.Compare("-1000", "7PS"));
            Assert.AreEqual(1, Base36.Compare("-10000", "LFLS"));
            Assert.AreEqual(1, Base36.Compare("-100000", "5YC1S"));
            Assert.AreEqual(1, Base36.Compare("-1000000", "GJDGXS"));
            Assert.AreEqual(1, Base36.Compare("-10000000", "4LDQPDS"));
            Assert.AreEqual(1, Base36.Compare("-100000000", "CRE66I9S"));
            Assert.AreEqual(1, Base36.Compare("-1000000000", "ZG3D62R5S"));
            Assert.AreEqual(1, Base36.Compare("-10000000000", "9UGXNORJLS"));
            Assert.AreEqual(1, Base36.Compare("-100000000000", "RCN1HSSIGHS"));
        }
    }
}
