using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluralNet.Interfaces;
using PluralNet.Providers;

namespace PluralNet.Core.Test.PluralProviders
{
    public class TestCzechProvider
    {
        IPluralProvider provider = new CzechProvider();

        [Theory]
        [InlineData(1, PluralTypeEnum.ONE)]
        [InlineData(2, PluralTypeEnum.FEW)]
        [InlineData(3, PluralTypeEnum.FEW)]
        [InlineData(4, PluralTypeEnum.FEW)]
        [InlineData(3.5, PluralTypeEnum.MANY)]
        [InlineData(0, PluralTypeEnum.OTHER)]
        [InlineData(5, PluralTypeEnum.OTHER)]
        [InlineData(7, PluralTypeEnum.OTHER)]
        [InlineData(15, PluralTypeEnum.OTHER)]
        [InlineData(-1, PluralTypeEnum.OTHER)]
        [InlineData(-2, PluralTypeEnum.OTHER)]
        [InlineData(-3, PluralTypeEnum.OTHER)]
        [InlineData(-4, PluralTypeEnum.OTHER)]
        [InlineData(-5, PluralTypeEnum.OTHER)]
        [InlineData(-6, PluralTypeEnum.OTHER)]
        [InlineData(-15, PluralTypeEnum.OTHER)]
        public void GetPlural(double number, PluralTypeEnum expected)
        {
            Assert.Equal(expected, provider.ComputePlural((decimal)number));
        }
    }
}
