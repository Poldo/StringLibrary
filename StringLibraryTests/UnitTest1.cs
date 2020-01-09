using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibrary;
using System;

namespace StringLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartWithUpper()
        {
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartWithUpper();
                Assert.IsTrue(result,
                              $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            foreach (string word in words)
            {
                bool result = word.StartWithUpper();
                Assert.IsFalse(result, $"Expected for '{word}': false; Actual: {result}");

            }
        }
        
        [TestMethod]
        public void DirectCallWithNullorEmpty()
        {
            string[] words = { String.Empty, null ,""};
            {
                foreach (string word in words) {
                    bool result = word.StartWithUpper();
                    Assert.IsFalse(result,
                                   $"Expected for '{(word == null ? "<null>" : word)}': " +
                                   $"false; Actual: {result}");
                    result = word.StartWithLower();
                    Assert.IsFalse(result,
                                   $"Expected for '{(word == null ? "<null>" : word)}': " +
                                   $"false; Actual: {result}");
                }

            }
        }
        [TestMethod]
        public void TestStartWithLower()
        {
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство" };
            foreach (var word in words)
            {
                bool result = word.StartWithLower();
                Assert.IsTrue(result,
                              $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithLower()
        {
            // Tests that we expect to return false.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва",
                       "1234", ".", ";", " "};
            foreach (var word in words)
            {
                bool result = word.StartWithLower();
                Assert.IsFalse(result,
                               $"Expected for '{word}': false; Actual: {result}");
            }
        }

        [TestMethod]
        public void TestHasEmbeddedSpaces()
        {
            // Tests that we expect to return true.
            string[] phrases = { "one car", "Name\u0009Description",
                         "Line1\nLine2", "Line3\u000ALine4",
                         "Line5\u000BLine6", "Line7\u000CLine8",
                         "Line0009\u000DLine10", "word1\u00A0word2" };
            foreach (var phrase in phrases)
            {
                bool result = phrase.HasEmbeddedSpace();
                Assert.IsTrue(result,
                              $"Expected for '{phrase}': true; Actual: {result}");
            }
        }
    }
}
