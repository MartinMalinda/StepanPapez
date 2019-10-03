using System;
using Xunit;
using Anagram;

namespace AnagramTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string string1 = "listen";
            string string2 = "silent";
            Assert.True(Program.IsAnagram(string1, string2));
        }
    }
}