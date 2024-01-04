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
    public class CroatProvider : IPluralProvider
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
                var integer = (int)n;
                if (integer % 10 == 1 && integer % 100 != 11)
                {
                    return PluralTypeEnum.ONE;
                }
                if ((integer % 10).IsBetween(2, 4) && !(integer % 100).IsBetween(12, 14))
                {
                    return PluralTypeEnum.FEW;
                }
            }
            var f = n.DigitsAfterDecimal();
            if (f % 10 == 1 && f % 100 != 11)
            {
                return PluralTypeEnum.ONE;
            }

            if ((f % 10).IsBetween(2, 4) && !(f % 100).IsBetween(12, 14))
            {
                return PluralTypeEnum.FEW;
            }

            return PluralTypeEnum.OTHER;
        }
    }
}
