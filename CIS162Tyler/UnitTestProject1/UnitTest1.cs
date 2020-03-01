using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleFramework;
namespace ConsoleFramework.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()] public void AddTwoTest() { FunctionsClass f = new FunctionsClass(); Assert.AreEqual(9, f.AddTwo(4, 5)); Assert.AreEqual(-1, f.AddTwo(4, -5)); }
        [TestMethod()] public void MinTwoTest() { FunctionsClass f = new FunctionsClass(); Assert.AreEqual(4, f.MinTwo(4, 5)); Assert.AreEqual(-5, f.MinTwo(4, -5)); }
        [TestMethod()] public void AvgThreeTest() { FunctionsClass f = new FunctionsClass(); Assert.AreEqual(5, f.AvgThree(4, 5, 6)); Assert.AreEqual(3, f.AvgThree(-1, 5, 5)); }
        [TestMethod()]
        public void SumTwoTest()
        {
            FunctionsClass f = new FunctionsClass();
            int[] vals = { 1, 2, 3, 4 }; Assert.AreEqual(6, f.SumTwo(vals, 1, 3));
        }
        [TestMethod()]
        public void SumRangeTest()
        {
            FunctionsClass f = new FunctionsClass();
            int[] vals = { 1, 2, 3, 4 }; Assert.AreEqual(6, f.SumRange(vals, 1, 3));
        }
        [TestMethod()]
        public void ResetTest()
        {
            FunctionsClass f = new FunctionsClass();
            f.Increase(10); f.Reset(); f.Increase(10); f.Increase(1); Assert.AreEqual(11, f.GetValue());
        }
        [TestMethod()]
        public void IncreaseTest()
        {
            FunctionsClass f = new FunctionsClass();
            f.Increase(10); f.Reset(); f.Increase(1); Assert.AreEqual(1, f.GetValue());
        }
        [TestMethod()]
        public void DecreaseTest()
        {
            FunctionsClass f = new FunctionsClass();
            f.Increase(10); f.Reset(); f.Increase(10); f.Decrease(1); f.Increase(100); Assert.AreEqual(109, f.GetValue());
        }
        [TestMethod()]
        public void GetValueTest()
        {
            FunctionsClass f = new FunctionsClass();
            f.Increase(10); f.Reset(); f.Increase(10); f.Increase(10); Assert.AreEqual(20, f.GetValue());
        }
    }
}