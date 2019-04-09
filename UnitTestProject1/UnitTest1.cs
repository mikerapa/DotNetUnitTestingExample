using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow("Mike", "Rapa", "MD", "Rapa, Mike (MD)")]
        [DataRow("Raj", "Patel", "", "Patel, Raj")]
        public void TestGetDisplayName(string firstName, string lastName, string position, string expectedDisplayName)
        {
            string displayName = ConsoleApp1.Program.GetDisplayName(firstName, lastName, position);
            Assert.AreEqual(expectedDisplayName, displayName);
        }
    }
}
