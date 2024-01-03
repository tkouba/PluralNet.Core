using PluralNet;
using System.Globalization;
using PluralNet.Interfaces;
using PluralNet.Utils;
using System.Resources;


namespace PluralNet
{
    public static class ResourceLoaderExtension
    {
        private static IPluralProvider _pluralProvider;
        private static object _objLock = new object();

        public static string GetPlural(this ResourceManager resource, string key, decimal number)
        {

            if (_pluralProvider == null)
            {
                lock (_objLock)
                {
                    if (_pluralProvider == null)
                    {
                        CultureInfo cultureToUse = null;
                        var forcedCulture = resource.GetString("ResourceLanguage");
                        if (!string.IsNullOrEmpty(forcedCulture))
                        {
                            try
                            {
                                cultureToUse = new CultureInfo(forcedCulture);
                            }
                            catch
                            {
                                cultureToUse = new CultureInfo(CultureInfo.CurrentUICulture.Name);
                            }
                        }
                        else
                        {
                            cultureToUse = new CultureInfo(CultureInfo.CurrentUICulture.Name);
                        }

                        _pluralProvider = PluralHelper.GetPluralChooser(cultureToUse);
                    }
                }
            }
            string selectedSentence = null;
            var pluralType = _pluralProvider.ComputePlural(number);
            try
            {
                switch (pluralType)
                {
                    case PluralTypeEnum.ZERO:
                        selectedSentence = resource.GetString(key + "_Zero");
                        break;
                    case PluralTypeEnum.ONE:
                        selectedSentence = resource.GetString(key + "_One");
                        break;
                    case PluralTypeEnum.OTHER:
                        selectedSentence = resource.GetString(key + "_Other");
                        break;
                    case PluralTypeEnum.TWO:
                        selectedSentence = resource.GetString(key + "_Two");
                        break;
                    case PluralTypeEnum.FEW:
                        selectedSentence = resource.GetString(key + "_Few");
                        break;
                    case PluralTypeEnum.MANY:
                        selectedSentence = resource.GetString(key + "_Many");
                        break;
                }
            }
            catch { }
            return selectedSentence ?? "";
        }

    }
}
