using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    public enum TransactionTypeEnum
    {
        Transfer = 0,           // Обычный перевод (Tavaline ülekanne)
        Buy = 1,                // Покупака (Ostmine)
        Sell = 2,               // Продажа (Müümine)
        CurrencyExchange = 3,   // Обмен валюты (Valuuta vahetamine)
        Dividend = 4,           // Дивиденды (Dividendimakse)
        ServiceFee = 5,         // Плата за обслуживание (Teenustasu)
    }
}
