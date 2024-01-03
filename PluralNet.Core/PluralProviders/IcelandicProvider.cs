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
    public class IcelandicProvider : IPluralProvider
    {
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
