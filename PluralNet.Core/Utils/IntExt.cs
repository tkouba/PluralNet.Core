/*
 * PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */

namespace PluralNet.Utils
{
    /// <summary>
    /// Integer (Int32 and Int64) extension for plural providers
    /// </summary>
    public static class IntExtension
    {
        /// <summary>
        /// Check if the number is in interval start and end (include both)
        /// </summary>
        /// <param name="number">number to check</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>true if number is in interval</returns>
        public static bool IsBetween(this int number, int start, int end)
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
        public static bool IsBetweenEndNotIncluded(this int number, int start, int end)
        {
            return start <= number && number < end;
        }

        /// <summary>
        /// Check if the number is in interval start and end (include both)
        /// </summary>
        /// <param name="number">number to check</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>true if number is in interval</returns>
        public static bool IsBetween(this long number, long start, long end)
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
        public static bool IsBetweenEndNotIncluded(this long number, long start, long end)
        {
            return start <= number && number < end;
        }


    }
}
