using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluralNet;

namespace PluralNet.Core.Test
{
    public class TestResourceLoader
    {
        [Theory]
        [InlineData(0)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(-5)]
        public void InvariantCulture(double n)
        {
            Properties.Resources.Culture = System.Globalization.CultureInfo.InvariantCulture;
            Assert.Equal(Properties.Resources.String_Other, Properties.Resources.ResourceManager.GetPlural("String", (decimal)n, Properties.Resources.Culture));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(-5)]
        public void NullCulture(double n)
        {
            Properties.Resources.Culture = null;
            Assert.NotEmpty(Properties.Resources.ResourceManager.GetPlural("String", (decimal)n, Properties.Resources.Culture));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(-5)]
        public void EnglishCulture(double n)
        {
            Properties.Resources.Culture = new System.Globalization.CultureInfo("en");
            Assert.Equal(n == 1 ? Properties.Resources.String_One : Properties.Resources.String_Other, 
                Properties.Resources.ResourceManager.GetPlural("String", (decimal)n, Properties.Resources.Culture));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(-1.5)]
        [InlineData(-5)]
        public void CzechCulture(double n)
        {
            Properties.Resources.Culture = new System.Globalization.CultureInfo("cs-CZ");
            string expected;
            if (n == 1)
                expected = Properties.Resources.String_One;
            else if (n == 2 || n == 3 || n == 4)
                expected = Properties.Resources.String_Few;
            else if (!double.IsInteger(n))
                expected = Properties.Resources.String_Many;
            else
                expected = Properties.Resources.String_Other;

            Assert.Equal(expected,
                Properties.Resources.ResourceManager.GetPlural("String", (decimal)n, Properties.Resources.Culture));
        }

    }
}
