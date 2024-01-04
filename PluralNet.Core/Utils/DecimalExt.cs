/*
 * PluralNet.Core
 * License MIT / http://bit.ly/mit-license
 *
 */

using System;

namespace PluralNet.Utils
{
    /// <summary>
    /// Decimal extension for plural providers
    /// </summary>
    public static class DecimalExtension
    {
        /// <summary>
        /// Check if the number is in interval start and end (include both)
        /// </summary>
        /// <param name="number">number to check</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>true if number is in interval</returns>
        public static bool IsBetween(this decimal number, decimal start, decimal end)
        {
            return start <= number && number <= end;
        }

        /// <summary>
        /// Check if the number is in interval start and end (include start, exclude end)
        /// </summary>
        /// <param name="number">number to check</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>true if number is in interval</returns>
        public static bool IsBetweenEndNotIncluded(this decimal number, decimal start, decimal end)
        {
            return start <= number && number < end;
        }

        /// <summary>
        /// Check if the number is an integer
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns>true if the number is an integer</returns>
        public static bool IsInt(this decimal number)
        {
            return (int)number == number;
        }

        /// <summary>
        /// Get number of digits after decimal
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns>Number of digits</returns>
        public static uint GetNumberOfDigitsAfterDecimal(this decimal number)
        {
            var text = number.ToString(System.Globalization.CultureInfo.InvariantCulture);
            var decpoint = text.IndexOf('.');
            if (decpoint < 0)
                return 0;
            return (uint)(text.Length - decpoint - 1);
        }

        /// <summary>
        /// Get digits after decimal (fractional part) as Int64
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns>Fractional part as integer</returns>
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
