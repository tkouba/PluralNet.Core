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
    public class HebrewProvider : IPluralProvider
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
                switch ((int)n)
                {
                    case 1:
                        return PluralTypeEnum.ONE;
                    case 2:
                        return PluralTypeEnum.TWO;
                }

                if (n != 0 && (n % 10) == 0)
                {
                    return PluralTypeEnum.MANY;
                }
            }
            return PluralTypeEnum.OTHER;

        }
    }
}
