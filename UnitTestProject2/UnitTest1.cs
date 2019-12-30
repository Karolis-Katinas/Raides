using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using raides;
using Raidės;
using System.Text;
using System.IO;
using System.Linq;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = "AbCd";
            var expected = "aBcD";
            //Act
            var result = TextCaseConverter.Convert(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
