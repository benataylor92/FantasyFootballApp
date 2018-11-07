using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FootballController.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testData = GetTestData();
            var controller = new FootballController(testData);

            var result = controller.result() as List<TestData>;
            Assert.AreEqual(testData.Count, result.Count);
        }

        private List<TestData> GetTestData()
        {
            var testData = new List<Footballer>();
            {
                testData.Add(new Footballer { FirstName = "Petr" });
            };

            return testData;
        }
    }
}
