/*
 * PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 *
 * Version 1.00
 */
using PluralNet.Interfaces;
using PluralNet.Utils;


namespace PluralNet.Providers
{
    /// <summary>
    /// This class supports the PluralNet infrastructure and is not intended to be used directly from your code.
    /// </summary>
    public class LatvianProvider : IPluralProvider
    {
        /// <summary>
        /// This method supports the PluralNet infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n == 0 || (n % 100).IsBetween(11, 19))
            {
                return PluralTypeEnum.ZERO;
            }

            var f = n.DigitsAfterDecimal();
            if (f.IsBetween(11, 19))
                return PluralTypeEnum.ZERO;

            if (n % 10 == 1 && n % 100 != 11)
                return PluralTypeEnum.ONE;
            if (f % 10 == 1)
            {
                if (n.GetNumberOfDigitsAfterDecimal() == 2)
                {
                    if (f % 100 != 11)
                        return PluralTypeEnum.ONE;
                }
                else
                {
                    return PluralTypeEnum.ONE;
                }
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
