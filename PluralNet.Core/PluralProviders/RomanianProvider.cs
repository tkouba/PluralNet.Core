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
    public class RomanianProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n.GetNumberOfDigitsAfterDecimal()>0 || n == 0 || (n != 1 && (n % 100).IsBetween(1, 19)))
            {
                return PluralTypeEnum.FEW;
            }
            if (n == 1)
            {
                return PluralTypeEnum.ONE;
            }
            return PluralTypeEnum.OTHER;

        }
    }
}
