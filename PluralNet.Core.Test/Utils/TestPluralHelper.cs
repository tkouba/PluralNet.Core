using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluralNet.Providers;
using PluralNet.Utils;

namespace PluralNet.Core.Test.Utils
{
    public class TestPluralHelper
    {
        [Theory]
        [InlineData("en", typeof(OnlyOneProvider))]
        [InlineData("cs", typeof(CzechProvider))]
        public void ChoosePluralProvider(string language, Type expected)
        {
            Assert.IsType(expected, PluralHelper.GetPluralChooser(language));
        }

        [Fact]
        public void ChooseInvariant()
        {
            Assert.IsType<OtherProvider>(PluralHelper.GetPluralChooser(System.Globalization.CultureInfo.InvariantCulture));
        }

    }
}
