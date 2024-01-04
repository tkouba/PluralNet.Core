/*
* PluralNet
* Author  Rudy Huyn (6Studio)
* License MIT / http://bit.ly/mit-license
*
* Version 1.00
*/

namespace PluralNet
{
    /// <summary>
    /// These plural categories are used to provide localized strings, with a more natural ways.
    /// </summary>
    public enum PluralTypeEnum
    {
        /// <summary>
        /// Zero
        /// </summary>
        ZERO,
        /// <summary>
        /// One (singular)
        /// </summary>
        ONE,
        /// <summary>
        /// Two (dual)
        /// </summary>
        TWO,
        /// <summary>
        /// Other (required—general plural form—also used if the language only has a single form)
        /// </summary>
        OTHER,
        /// <summary>
        /// Few (paucal)
        /// </summary>
        FEW,
        /// <summary>
        /// Many (also used for fractions if they have a separate class)
        /// </summary>
        MANY
    };
}
