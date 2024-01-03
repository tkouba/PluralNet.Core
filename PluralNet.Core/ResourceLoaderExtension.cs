using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Resources;
using PluralNet.Interfaces;
using PluralNet.Utils;

namespace PluralNet
{
    public static class ResourceLoaderExtension
    {
        private static ConcurrentDictionary<string, IPluralProvider> _pluralProviders = new ConcurrentDictionary<string, IPluralProvider>();

        public static void SetPluralProvider(CultureInfo cultureInfo, IPluralProvider provider)
        {
            _pluralProviders.AddOrUpdate(cultureInfo.TwoLetterISOLanguageName, provider, (key, old) => provider);
        }

        public static string GetPlural(this ResourceManager resource, string key, decimal number, CultureInfo cultureToUse = null)
            => GetPlural<ResourceManager>((reskey, culture) => resource.GetString(reskey, culture), key, number, cultureToUse);

        public static string GetPlural<T>(Func<string, CultureInfo, string> getString, string key, decimal number, CultureInfo cultureToUse)
        {
            if (cultureToUse == null)
            {
                cultureToUse = CultureInfo.CurrentUICulture;
            }

            IPluralProvider pluralProvider = _pluralProviders.GetOrAdd(cultureToUse.TwoLetterISOLanguageName, (twoLetterISOLanguageName) => PluralHelper.GetPluralChooser(twoLetterISOLanguageName));

            if (pluralProvider == null)
                return string.Empty;

            string selectedSentence = null;
            var pluralType = pluralProvider.ComputePlural(number);
            try
            {
                switch (pluralType)
                {
                    case PluralTypeEnum.ZERO:
                        selectedSentence = getString(key + "_Zero", cultureToUse);
                        break;
                    case PluralTypeEnum.ONE:
                        selectedSentence = getString(key + "_One", cultureToUse);
                        break;
                    case PluralTypeEnum.OTHER:
                        selectedSentence = getString(key + "_Other", cultureToUse);
                        break;
                    case PluralTypeEnum.TWO:
                        selectedSentence = getString(key + "_Two", cultureToUse);
                        break;
                    case PluralTypeEnum.FEW:
                        selectedSentence = getString(key + "_Few", cultureToUse);
                        break;
                    case PluralTypeEnum.MANY:
                        selectedSentence = getString(key + "_Many", cultureToUse);
                        break;
                }
            }
            catch { }
            return selectedSentence ?? string.Empty;
        }

    }
}
