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
    public class ArabicProvider : IPluralProvider
    {
        /// <summary>
        /// This method supports the PluralNet infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n.IsInt())
            {
                if (n == 0)
                {
                    return PluralTypeEnum.ZERO;
                }
                if (n == 1)
                {
                    return PluralTypeEnum.ONE;
                }
                if (n == 2)
                {
                    return PluralTypeEnum.TWO;
                }
                if ((n % 100).IsBetween(3, 10))
                {
                    return PluralTypeEnum.FEW;
                }
                if ((n % 100).IsBetween(11, 99))
                {
                    return PluralTypeEnum.MANY;
                }
            }
            return PluralTypeEnum.OTHER;

        }
    }
}
