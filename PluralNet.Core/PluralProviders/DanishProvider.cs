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
    public class DanishProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n != 0 && n.IsBetween(0, 1))
                return PluralTypeEnum.ONE;
            return PluralTypeEnum.OTHER;
        }
    }
}