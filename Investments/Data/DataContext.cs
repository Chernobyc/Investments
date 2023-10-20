using System.Collections.Generic;
using Investments.Collections;

namespace Investments.Data
{
    public class DataContext
    {
        public InstitutionsList Institutions = new InstitutionsList();    //экземпляр списка учреждений
        public List<Account> Accounts = new List<Account>();              //экземпляр списка аккаунтов
        public SecurablesList Securables = new SecurablesList();          //экземпляр списка акций
        public ExchangeRatesList ExchangeRates = new ExchangeRatesList(); //экземпляр списка изменений курса
        public List<Transaction> Transactions = new List<Transaction>();  //экземпляр списка транзакций
        public List<TransactionEntry> TransactionEntries = new List<TransactionEntry>(); //экземпляр списка с записями транзакицй
    }
}
