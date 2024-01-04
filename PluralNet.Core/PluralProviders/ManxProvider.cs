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
    public class ManxProvider : IPluralProvider
    {
        /// <summary>
        /// This method supports the PluralNet infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();
            var i = (int)n;
            if (isInt)
            {
                if (i % 10 == 1)
                    return PluralTypeEnum.ONE;
                if (i % 10 == 2)
                    return PluralTypeEnum.TWO;
                if (i % 20 == 0)
                    return PluralTypeEnum.FEW;
                return PluralTypeEnum.OTHER;
            }
            else
            {
                return PluralTypeEnum.MANY;
            }
        }
    }
}
