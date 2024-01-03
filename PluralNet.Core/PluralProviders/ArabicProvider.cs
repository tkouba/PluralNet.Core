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
    public class ArabicProvider : IPluralProvider
    {
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
