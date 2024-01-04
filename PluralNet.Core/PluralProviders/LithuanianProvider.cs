﻿/*
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
    public class LithuanianProvider : IPluralProvider
    {
        /// <summary>
        /// This method supports the PluralNet infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if ((n % 10).IsBetween(2, 9) && !(n % 100).IsBetween(11, 19))
            {
                return PluralTypeEnum.FEW;
            }
            if ((n % 10) == 1 && !(n % 100).IsBetween(11, 19))
            {
                return PluralTypeEnum.ONE;
            }
            if (n.GetNumberOfDigitsAfterDecimal() != 0)
                return PluralTypeEnum.MANY;
            return PluralTypeEnum.OTHER;

        }
    }
}
