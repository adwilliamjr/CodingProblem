using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblem2And3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("reversed_string", "gnirts_desrever")]
        [DataRow("alexander william jr", "rj mailliw rednaxela")]
        [TestMethod]
        public void string_should_reverse(string testString, string expected)
        {
            var result = testString.Reverse(testString);

            Assert.AreEqual(expected, result);
        }

        [DataRow("abcdeafgehiaajk", "abcdefghijk")]
        [DataRow("aaa", "a")]
        [DataRow("aa1", "a1")]
        [DataRow("alexander william jr", "alexndr wimj")]
        [TestMethod]
        public void string_should_have_no_duplicates(string testString, string expected)
        {
            var result = testString.RemoveDuplicates(testString);

            Assert.AreEqual(expected, result);
        }
    }
}
