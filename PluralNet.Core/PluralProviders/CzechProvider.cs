﻿/*
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
    public class CzechProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n == 1)
                return PluralTypeEnum.ONE;

            if (n.GetNumberOfDigitsAfterDecimal() != 0)
            {
                return PluralTypeEnum.MANY;
            }

            if (n.IsBetween(2, 4))
                return PluralTypeEnum.FEW;

            return PluralTypeEnum.OTHER;
        }
    }
}
