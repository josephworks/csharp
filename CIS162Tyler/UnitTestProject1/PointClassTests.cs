using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFramework.Tests
{
    [TestClass()]
    public class PointClassTests
    {
        [TestMethod()]
        public void ConstructorTest()
        {
            PointClass p = new PointClass(1, 2);
            Assert.AreEqual(1, p.getX());
            Assert.AreEqual(2, p.getY());
        }
        [TestMethod()]
        public void toStringTest()
        {
            PointClass p = new PointClass(1, 2);
            Assert.AreEqual("(1,2)", p.ToString());
        }
        [TestMethod()]
        public void QuadrantTest()
        {
            PointClass p1 = new PointClass(1, 2);
            Assert.AreEqual(1, p1.Quadrant());
            PointClass p2 = new PointClass(-1, 2);
            Assert.AreEqual(2, p2.Quadrant());
            PointClass p3 = new PointClass(-1, -2);
            Assert.AreEqual(3, p3.Quadrant());
            PointClass p4 = new PointClass(1, -2);
            Assert.AreEqual(4, p4.Quadrant());
        }
        [TestMethod()]
        public void ReflectXTest()
        {
            PointClass p = new PointClass(1, 2);
            p.reflextX();
            Assert.AreEqual("(1,-2)", p.ToString());
        }
        [TestMethod()]
        public void ReflectYTest()
        {
            PointClass p = new PointClass(1, 2);
            p.reflextX();
            Assert.AreEqual("(1,-2)", p.ToString());
        }

        [TestMethod()]
        public void distanctTest()
        {
            PointClass p = new PointClass(3, 4);
            p.reflextX();
            Assert.AreEqual(5, p.distanceFromOrigin());
        }
        
        [TestMethod()]
        public void moveTest()
        {
            PointClass p = new PointClass(3, 4);
            p.move(-2,4);
            Assert.AreEqual("(1,8)", p.ToString());
        }

        [TestMethod()]
        public void scaleTest()
        {
            PointClass p = new PointClass(3, 4);
            p.scale(4);
            Assert.AreEqual("(12,16)", p.ToString());
        }

    }
}