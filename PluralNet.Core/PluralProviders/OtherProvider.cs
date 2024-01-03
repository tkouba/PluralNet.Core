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
    public class OtherProvider:IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            return PluralTypeEnum.OTHER;
        }
    }
}
