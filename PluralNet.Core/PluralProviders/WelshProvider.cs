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
    public class WelshProvider : IPluralProvider
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
                var i = (int)n;
                switch (i)
                {
                    case 0:
                        return PluralTypeEnum.ZERO;
                    case 1:
                        return PluralTypeEnum.ONE;
                    case 2:
                        return PluralTypeEnum.TWO;
                    case 3:
                        return PluralTypeEnum.FEW;
                    case 6:
                        return PluralTypeEnum.MANY;
                }
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
