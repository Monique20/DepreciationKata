using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationCalculatorKata
{
    public class DepreciationCalculator
    {
        public int CalculateDepreciation(int assetValue,int salvage,int usefulYears)
        {
            var depreciation = (assetValue - salvage) / usefulYears;
            return depreciation;
        }
    }
    }
