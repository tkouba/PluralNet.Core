using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Resources;
using PluralNet.Interfaces;
using PluralNet.Utils;

namespace PluralNet
{
    /// <summary>
    /// Extension class for resource loader
    /// </summary>
    public static class ResourceLoaderExtension
    {
        private static ConcurrentDictionary<string, IPluralProvider> _pluralProviders = new ConcurrentDictionary<string, IPluralProvider>();

        /// <summary>
        /// Override plural provider detection for the culture
        /// </summary>
        /// <param name="cultureInfo">Culture for override</param>
        /// <param name="provider">Plural provider for the culture</param>
        public static void SetPluralProvider(CultureInfo cultureInfo, IPluralProvider provider)
        {
            _pluralProviders.AddOrUpdate(cultureInfo.TwoLetterISOLanguageName, provider, (key, old) => provider);
        }

        /// <summary>
        /// Get plural form of string from ResourceManager
        /// </summary>
        /// <param name="resource">ResourceManager to get string from</param>
        /// <param name="key">String key (base key)</param>
        /// <param name="number">Number for pluralization</param>
        /// <param name="cultureToUse">Culture, default is current UI culture</param>
        /// <returns>Pluralized string</returns>
        public static string GetPlural(this ResourceManager resource, string key, decimal number, CultureInfo cultureToUse = null)
            => GetPlural<ResourceManager>((reskey, culture) => resource.GetString(reskey, culture), key, number, cultureToUse);

        /// <summary>
        /// Generic function for get plural form of string from type using function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="getString">Function to get string from reource</param>
        /// <param name="key">String key (base key)</param>
        /// <param name="number">Number for pluralization</param>
        /// <param name="cultureToUse">Culture, default is current UI culture</param>
        /// <returns>Pluralized string</returns>
        /// <remarks>This method supports the PluralNet infrastructure and is not usually used from your code.</remarks>
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
