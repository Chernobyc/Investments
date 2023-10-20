using System.Collections.Generic;
using System.Linq;

namespace Investments.Collections
{
    public class SecurablesList : List<Securable>
    {
        public Securable GetByTicker(string ticker)
        {
            return this.FirstOrDefault(securable => securable.Ticker.ToLower() == ticker.ToLower());
        }
    }
}
