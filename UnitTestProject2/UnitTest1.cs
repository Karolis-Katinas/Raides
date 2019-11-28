using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using System.Collections.Generic;
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
            string path = (@"C:\Users\grauk\Desktop\Objectinis programavimas\Raides\raides.txt");
            List<string> inputstring = new List<string> { };
            List<string> outputstring = new List<string> { };

            //Act
            inputstring = File.ReadAllLines(path).ToList();
            outputstring = TextCaseConverter.ConvertText(inputstring);

            //assert
            Assert.IsNotNull(inputstring);
            Assert.IsNotNull(outputstring);

            int i = 0;
            foreach (string line in inputstring)
            {
                int j = 0;
                foreach (char symbol in line)
                {
                    if (Char.IsUpper(symbol))
                    {
                        Assert.IsTrue(char.ToLower(symbol) == outputstring.ElementAt<string>(i).ElementAt<char>(j));
                    }
                    else if (Char.IsLower(symbol))
                    {
                        Assert.IsTrue(char.ToUpper(symbol) == outputstring.ElementAt<string>(i).ElementAt<char>(j));
                    }
                    else
                    {
                        Assert.IsTrue(symbol == outputstring.ElementAt<string>(i).ElementAt<char>(j));
                    }
                    j++;
                }
                i++;
            }

        }
    }
}
