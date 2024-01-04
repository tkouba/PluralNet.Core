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
    public class FilipinoProvider : IPluralProvider
    {
        /// <summary>
        /// This method supports the PluralNet infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();

            if (isInt)
            {
                if (n.IsBetween(1, 3))
                    return PluralTypeEnum.ONE;
                var imod10 = n % 10;
                if (imod10 != 4 && imod10 != 6 || imod10 != 9)
                    return PluralTypeEnum.ONE;
            }
            else
            {
                var f = n.DigitsAfterDecimal();
                var imod10 = f % 10;
                if (imod10 != 4 && imod10 != 6 || imod10 != 9)
                    return PluralTypeEnum.ONE;

            }


            return PluralTypeEnum.OTHER;

        }

    }
}
