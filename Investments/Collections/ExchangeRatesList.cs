using System;
using System.Collections.Generic;
using System.Linq;

namespace Investments.Collections
{
    public class ExchangeRatesList : List<ExchangeRate>
    {
        public ExchangeRate GetRate(DateTime date, Securable securable)
        {
            return this.FirstOrDefault(rate => rate.Date == date.Date && rate.From == securable);
        }
    }
}