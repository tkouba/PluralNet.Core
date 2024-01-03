/*
 * PluralNet.Core
 * License MIT / http://bit.ly/mit-license
 *
 */

using System;

namespace PluralNet.Utils
{
    public static class DecimalExtension
    {
        public static bool IsBetween(this decimal number, decimal start, decimal end)
        {
            return start <= number && number <= end;
        }
        public static bool IsBetweenEndNotIncluded(this decimal number, decimal start, decimal end)
        {
            return start <= number && number < end;
        }

        public static bool IsInt(this decimal number)
        {
            return (int)number == number;
        }

        public static uint GetNumberOfDigitsAfterDecimal(this decimal number)
        {
            var text = number.ToString(System.Globalization.CultureInfo.InvariantCulture);
            var decpoint = text.IndexOf('.');
            if (decpoint < 0)
                return 0;
            return (uint)(text.Length - decpoint - 1);
        }


        public static long DigitsAfterDecimal(this decimal number)
        {
            try
            {
                var text = number.ToString(System.Globalization.CultureInfo.InvariantCulture);
                var decpoint = text.IndexOf('.');
                if (decpoint < 0)
                    return 0;
                var str = text.Substring(decpoint + 1);
                if (str == String.Empty)
                    return 0;
                return long.Parse(str);
            }
            catch
            {
                return 0;
            }
        }
    }
}
