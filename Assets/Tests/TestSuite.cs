using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        [Test]
        public void TestAddition()
        {
            //use the assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        //subtraction
        [Test]
        public void TestSubtract()
        {
            //use the assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        //multipication
        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
               
        }
        //division
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        //square root
        [Test]
        public void TestSquareRoot()
        {
            result = Calculator.CalculatePair(64, 2, "√");
            Assert.AreEqual(result, 8);
        }
        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(8, 2, "^");
            Assert.AreEqual(result, 64);
        }


        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            //use the assert class to test conditions
            //use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [UnityTest]
        public IEnumerator TestUnitySubtract()
        {
            //use the assert class to test conditions
            //use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnityMultiply()
        {
            //use the assert class to test conditions
            //use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnityDivide()
        {
            //use the assert class to test conditions
            //use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnitySquareRoot()
        {
            //use the assert class to test conditions
            //use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(64, 2, "√");
            Assert.AreEqual(result, 8);
        }
        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            //use the assert class to test conditions
            //use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(8, 2, "^");
            Assert.AreEqual(result, 64);
        }


    }
}
