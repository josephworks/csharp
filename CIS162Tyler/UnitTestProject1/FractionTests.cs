using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void addFracTest()
        {
            Fraction n1 = new Fraction(1, 2);
            Fraction n2 = new Fraction(1, 4);
            n1.add(n2);

            Assert.AreEqual("3/4", n1.add(n2).ToString());

        }

        [TestMethod()]
        public void subFracTest()
        {
            Fraction n1 = new Fraction(1, 2);
            Fraction n2 = new Fraction(3, 4);
            n2.subtract(n1);

            Assert.AreEqual("1/4", n2.subtract(n1).ToString());
        }

        [TestMethod()]
        public void multFracTest()
        {
            Fraction n1 = new Fraction(1, 2);
            Fraction n2 = new Fraction(3, 4);

            n1.multiply(n2);

            Assert.AreEqual("3/8", n1.multiply(n2).ToString());
        }

        [TestMethod()]
        public void divFracTest()
        {
            Fraction n1 = new Fraction(1, 2);
            Fraction n2 = new Fraction(3, 4);

            n1.divide(n2);

            Assert.AreEqual("2/3", n1.divide(n2).ToString());

        }
    }
}
