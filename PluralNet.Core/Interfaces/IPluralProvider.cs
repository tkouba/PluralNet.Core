/*
* PluralNet
* Author  Rudy Huyn (6Studio)
* License MIT / http://bit.ly/mit-license
*
* Version 1.00
*/

using static System.Net.WebRequestMethods;

namespace PluralNet.Interfaces
{
    /// <summary>
    /// Pluralization provider interface
    /// </summary>
    public interface IPluralProvider
    {
        /// <summary>
        /// Compute plural category type.
        /// </summary>
        /// <param name="n">Number for plural category detection.</param>
        /// <returns>Plural category type</returns>
        /// <remarks>See https://www.unicode.org/cldr/charts/44/supplemental/language_plural_rules.html for more information about return values.</remarks>
        PluralTypeEnum ComputePlural(decimal n);
    }
}