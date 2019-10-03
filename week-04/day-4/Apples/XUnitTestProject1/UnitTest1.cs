using Apples;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Apple apple;
        public UnitTest1()
        {
            apple = new Apple();
        }

        [Fact]
        void Test1()
        {
            Assert.Equal("Apple", apple.GetApple());
        }

    }
}
