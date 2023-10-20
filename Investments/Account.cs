using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    // Konto pangas, börsil või mõne muu institutsiooni juures
    // Счет в банке, бирже или другом учреждении
    public class Account
    {
        public string AccountNo { get; set; }
        public string Name { get; set; }
        public AccountTypeEnum Type { get; set; }

        public Institution Institution { get; set; }

        public List<TransactionEntry> Entries { get; set; } //ссылка на список записей

        public Account()
        {
            Entries = new List<TransactionEntry>(); 
        }
    }
}
