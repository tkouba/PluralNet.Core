using PluralNet.Utils;

namespace PluralNet.Core.Test.Utils
{
    public class TestDecimalExt
    {
        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(3, 1, 5)]
        [InlineData(3.5, 1, 5)]
        [InlineData(5, 1, 5)]
        public void IsBetween(double number, double start, double end)
        {
            Assert.True(((decimal)number).IsBetween(((decimal)start), ((decimal)end)));
        }

        [Theory]
        [InlineData(0, 1, 5)]
        [InlineData(0.999, 1, 5)]
        [InlineData(5.01, 1, 5)]
        [InlineData(6, 1, 5)]
        public void IsNotBetween(double number, double start, double end)
        {
            Assert.False(((decimal)number).IsBetween(((decimal)start), ((decimal)end)));
        }

        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(3, 1, 5)]
        [InlineData(3.5, 1, 5)]
        public void IsBetweenEndNotIncluded(double number, double start, double end)
        {
            Assert.True(((decimal)number).IsBetweenEndNotIncluded(((decimal)start), ((decimal)end)));
        }

        [Theory]
        [InlineData(0, 1, 5)]
        [InlineData(0.999, 1, 5)]
        [InlineData(5, 1, 5)]
        [InlineData(5.01, 1, 5)]
        [InlineData(6, 1, 5)]
        public void IsNotBetweenEndNotIncluded(double number, double start, double end)
        {
            Assert.False(((decimal)number).IsBetweenEndNotIncluded(((decimal)start), ((decimal)end)));
        }


        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(-3)]
        public void IsInt(double number)
        {
            Assert.True(((decimal)number).IsInt());
        }

        [Theory]
        [InlineData(0.999)]
        [InlineData(5.01)]
        [InlineData(-0.999)]
        public void IsNotInt(double number)
        {
            Assert.False(((decimal)number).IsInt());
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(3, 0)]
        [InlineData(-3, 0)]
        [InlineData(0.999, 3)]
        [InlineData(5.01, 2)]
        [InlineData(-0.999, 3)]
        [InlineData(-5.999, 3)]
        public void GetNumberOfDigitsAfterDecimal(double number, uint expected)
        {
            Assert.Equal(expected, ((decimal)number).GetNumberOfDigitsAfterDecimal());
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(3, 0)]
        [InlineData(-3, 0)]
        [InlineData(0.999, 999)]
        [InlineData(5.01, 1)]
        [InlineData(-0.999, 999)]
        [InlineData(-5.999, 999)]
        public void DigitsAfterDecimal(double number, long expected)
        {
            Assert.Equal(expected, ((decimal)number).DigitsAfterDecimal());
        }

    }
}