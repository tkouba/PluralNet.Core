using PluralNet.Utils;

namespace PluralNet.Core.Test.Utils
{
    public class TestIntExt
    {
        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(3, 1, 5)]
        [InlineData(5, 1, 5)]
        public void Int32_IsBetween(int number, int start, int end)
        {
            Assert.True(number.IsBetween(start, end));
        }

        [Theory]
        [InlineData(-1, 1, 5)]
        [InlineData(0, 1, 5)]
        [InlineData(6, 1, 5)]
        public void Int32_IsNotBetween(int number, int start, int end)
        {
            Assert.False(number.IsBetween(start, end));
        }

        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(3, 1, 5)]
        [InlineData(4, 1, 5)]
        public void Int32_IsBetweenEndNotIncluded(int number, int start, int end)
        {
            Assert.True(number.IsBetweenEndNotIncluded(start, end));
        }

        [Theory]
        [InlineData(-1, 1, 5)]
        [InlineData(0, 1, 5)]
        [InlineData(5, 1, 5)]
        [InlineData(6, 1, 5)]
        public void Int32_IsNotBetweenEndNotIncluded(int number, int start, int end)
        {
            Assert.False(number.IsBetweenEndNotIncluded(start, end));
        }


        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(3, 1, 5)]
        [InlineData(5, 1, 5)]
        public void Int64_IsBetween(long number, long start, long end)
        {
            Assert.True(number.IsBetween(start, end));
        }

        [Theory]
        [InlineData(-1, 1, 5)]
        [InlineData(0, 1, 5)]
        [InlineData(6, 1, 5)]
        public void Int64_IsNotBetween(long number, long start, long end)
        {
            Assert.False(number.IsBetween(start, end));
        }

        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(3, 1, 5)]
        [InlineData(4, 1, 5)]
        public void Int64_IsBetweenEndNotIncluded(long number, long start, long end)
        {
            Assert.True(number.IsBetweenEndNotIncluded(start, end));
        }

        [Theory]
        [InlineData(-1, 1, 5)]
        [InlineData(0, 1, 5)]
        [InlineData(5, 1, 5)]
        [InlineData(6, 1, 5)]
        public void Int64_IsNotBetweenEndNotIncluded(long number, long start, long end)
        {
            Assert.False(number.IsBetweenEndNotIncluded(start, end));
        }

    }
}