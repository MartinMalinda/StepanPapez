using Xunit;
using Sum;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private SumList sumList;
        public UnitTest1()
        {
            sumList = new SumList();
        }

        [Fact]
        public void Test1()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(21, sumList.SumIt(list));
        }

        [Fact]
        public void Test2()
        {
            var list = new List<int>() { };
            Assert.Equal(0, sumList.SumIt(list));
        }

        [Fact]
        public void Test3()
        {
            var list = new List<int>() {6};
            Assert.Equal(6, sumList.SumIt(list));
        }

        [Fact]
        public void Test4()
        {
            List<int> list = null;
            Assert.Equal(0, sumList.SumIt(list));
        }

        /*[Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6})]
        [InlineData(new int[] { })]
        [InlineData(new int[] { 6 })]
        [InlineData(null)]
        public void Test1(int[] numbers)
        {
            var list = new List<int>(numbers);
            Assert.Equal(21, sumList.SumIt(list));
        }*/
    }
}
