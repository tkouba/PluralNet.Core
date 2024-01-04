using PluralNet;
using PluralNet.Interfaces;
using PluralNet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralNet.Providers
{
    /// <summary>
    /// This class supports the PluralNet infrastructure and is not intended to be used directly from your code.
    /// </summary>
    public class IcelandicProvider : IPluralProvider
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
                var integer = (int)n;
                if (integer % 10 == 1 && integer % 100 != 11)
                {
                    return PluralTypeEnum.ONE;
                }
                return PluralTypeEnum.OTHER;
            }
            else
            {
                return PluralTypeEnum.ONE;
            }


        }
    }
}
