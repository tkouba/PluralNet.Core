﻿/*
 * PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */
using PluralNet.Interfaces;

namespace PluralNet.Providers
{
    public class OnlyOneProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n == 1)
            {
                return PluralTypeEnum.ONE;
            }
            else
            {
                return PluralTypeEnum.OTHER;
            }
        }

    }
}
