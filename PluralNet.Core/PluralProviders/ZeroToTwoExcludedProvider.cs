/*
 * PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 *
 * Version 1.00
 */
using PluralNet.Utils;
using PluralNet.Interfaces;

namespace PluralNet.Providers
{
    /// <summary>
    /// This class supports the PluralNet infrastructure and is not intended to be used directly from your code.
    /// </summary>
    public class ZeroToTwoExcludedProvider : IPluralProvider
    {
        /// <summary>
        /// This method supports the PluralNet infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n.IsBetweenEndNotIncluded(0, 2))
            {
                return PluralTypeEnum.ONE;
            }
            else
            {
                return PluralTypeEnum.OTHER;
            }
        }

    }
}
