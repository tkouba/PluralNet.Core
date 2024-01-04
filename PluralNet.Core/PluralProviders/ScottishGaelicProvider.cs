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
    /// <summary>
    /// This class supports the PluralNet infrastructure and is not intended to be used directly from your code.
    /// </summary>
    public class ScottishGaelicProvider : IPluralProvider
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
                var i = (int)n;
                switch (i)
                {
                    case 1:
                    case 11:
                        return PluralTypeEnum.ONE;
                    case 2:
                    case 12:
                        return PluralTypeEnum.TWO;
                }
                if (i <= 19)
                    return PluralTypeEnum.FEW;
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
