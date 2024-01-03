﻿/*
* PluralNet
* Author  Rudy Huyn (6Studio)
* License MIT / http://bit.ly/mit-license
*
* Version 1.00
*/

namespace PluralNet.Interfaces
{
    public interface IPluralProvider
    {
        PluralTypeEnum ComputePlural(decimal n);
    }
}