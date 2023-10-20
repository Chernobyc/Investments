using System.Collections.Generic;
using System.Linq;

namespace Investments.Collections
{
    public class InstitutionsList : List<Institution>
    {
        public Institution GetByName(string name)
        {
            return this.FirstOrDefault(institution => institution.Name.ToLower() == name.ToLower());
        }
    }
}