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
    public class MacedonianProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {

            if (n.IsInt())
            {
                if (n % 10 == 1)
                    return PluralTypeEnum.ONE;
            }
            else
            {
                var f = n.DigitsAfterDecimal();
                if (f % 10 == 1)
                    return PluralTypeEnum.ONE;

            }
            return PluralTypeEnum.OTHER;
        }
    }
}
