using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using System.Collections.Generic;
using raides;
using Raidės;
using System.Text;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> l = new List<string>();
            l.Add("sdgfop]kasod[kokkOIJčęįįęįčįęččęįčIJIJKOPK");
            l.Add("8uhjnsdfjasfd[]'");
            TextConverter t = new TextConverter(l);
            StringBuilder sb = new StringBuilder();
            foreach (string Line in t.GetText())
            {
                int i = 0;
                foreach (char symbol in Line)
                {
                    if (Char.IsUpper(symbol))
                    {
                        sb.Insert(i, char.ToLower(symbol));
                        Assert.IsTrue(sb[i]!=symbol);
                    }
                    else if (Char.IsLower(symbol))
                    {
                        sb.Insert(i, char.ToUpper(symbol));
                        Assert.IsTrue(sb[i] != symbol);
                    }
                    else
                    {
                        sb.Insert(i, symbol);
                        Assert.IsTrue(sb[i] == symbol);
                    }
                    i++;
                }
            }
        }
    }
}
