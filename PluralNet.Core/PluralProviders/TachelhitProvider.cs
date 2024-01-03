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
    public class TachelhitProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if ((int)n == 0 || n == 1)
            {
                return PluralTypeEnum.ONE;
            }
            if (n <= 10 && (int)n == n)
                return PluralTypeEnum.FEW;

            return PluralTypeEnum.OTHER;
        }
    }
}
