using System;
using System.Globalization;

namespace Investments.Data
{
    public static class TransactionsGenerator
    {
        //private DateTime[] dates;  
        //private static void GenerateDate()
        //{
            
        //}
        public static void GenerateTransactions(DataContext context)
        {
                    /*
         * 0 eur
         * 1 msft
         * 2 aapl
         * 3 goog
         */

            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-01-02 10:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-04 14:45:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-05 09:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-06 16:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-01-8 11:10:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-12 17:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-15 10:25:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-16 15:40:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-01-20 09:05:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-23 14:50:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-25 11:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-01-28 13:45:00") });


            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-02-05 10:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-02-14 14:45:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-02-20 09:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-02-23 16:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-02-25 11:10:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-02-28 17:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-03-05 10:25:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-03-15 15:40:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-03-25 09:05:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-04-05 14:50:00") });

            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-04-15 11:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-04-25 13:45:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-05-05 08:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-05-15 15:10:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-05-25 10:55:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-06-05 14:25:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-06-15 09:40:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-06-25 12:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-07-05 16:35:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-15 07:55:00") });

            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-07-25 14:15:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-08-05 10:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-08-15 14:45:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-08-25 09:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-09-05 16:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-09-15 11:10:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-09-25 17:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-10-05 10:25:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-10-15 15:40:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-10-25 09:05:00") });

            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-11-05 14:50:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-11-15 11:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-11-25 13:45:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2023-12-05 08:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-12-15 15:10:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-25 10:55:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2024-01-05 14:25:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2024-01-15 09:40:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2024-01-25 12:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-02-05 16:35:00") });

            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2024-02-15 07:55:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2024-02-25 14:15:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2024-03-05 10:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-03-15 14:45:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2024-03-25 09:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2024-04-05 16:20:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2024-04-15 11:10:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-04-25 17:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2024-05-05 10:25:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum.Buy, Time = DateTime.Parse("2024-05-15 15:40:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2024-05-25 09:05:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-06-05 14:50:00") });



            //context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-01-02 16:30:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.ServiceFee, Time = DateTime.Parse("2023-02-02 18:30:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-02-15 17:05:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[1] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-02-28 17:07:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[1] , Type = TransactionTypeEnum.Sell , Time = DateTime.Parse("2023-03-04 15:30:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[1] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-03-12 12:30:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[3] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-03-26 08:29:00") });

            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Sell, Time = DateTime.Parse("2023-04-01 17:05:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-04-03 11:03:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[0], Type = TransactionTypeEnum.CurrencyExchange, Time = DateTime.Parse("2023-04-05 12:15:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[1], Type = TransactionTypeEnum., Time = DateTime.Parse("2023-04-10 14:12:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-04-16 15:25:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-04-25 19:27:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-05-03 17:05:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-05-10 17:05:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-05-17 13:44:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-05-25 11:34:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-06-11 16:21:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-06-17 18:34:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-06-28 08:49:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-05 10:58:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-10 15:48:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-12 16:34:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-15 11:57:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-21 14:38:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-07-29 19:49:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-08-05 11:37:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-08-17 19:28:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-08-26 17:24:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-09-01 12:18:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-09-07 14:55:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-09-18 13:17:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-10-08 12:35:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-10-22 16:15:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-11-06 13:27:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-11-18 20:25:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-11-30 21:57:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-04 15:45:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-15 16:35:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-21 18:19:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-23 19:45:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-26 18:47:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-28 11:27:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2023-12-30 19:37:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-01-02 12:18:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-01-18 21:19:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-02-07 15:51:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-02-19 22:01:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-03-03 19:15:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-03-28 18:36:00") });
            //context.Transactions.Add(new Transaction { Name = context.Securables[2], Type = TransactionTypeEnum.Transfer, Time = DateTime.Parse("2024-04-06 17:12:39") });


           /* 
            context.Transactions.Add(new Transaction { Name = "18.05.2023 MSFT Buy" , Time = DateTime.Parse("2023-05-18 19:10:00") });
            context.Transactions.Add(new Transaction { Name = "23.05.2023 MSFT Buy" , Time = DateTime.Parse("2023-05-23 16:50:00") });
            context.Transactions.Add(new Transaction { Name = "28.05.2023 GOOG Sell", Time = DateTime.Parse("2023-05-28 13:47:00") });
            context.Transactions.Add(new Transaction { Name = "02.06.2023 AAPL Buy" , Time = DateTime.Parse("2023-06-02 21:20:00") });
            context.Transactions.Add(new Transaction { Name = "19.06.2023 AAPL Sell", Time = DateTime.Parse("2023-06-19 18:10:00") });
            context.Transactions.Add(new Transaction { Name = "26.06.2023 GOOG Buy" , Time = DateTime.Parse("2023-06-26 15:59:00") });
            context.Transactions.Add(new Transaction { Name = "29.06.2023 MSFT Sell", Time = DateTime.Parse("2023-06-29 10:20:00") });
           */

        }
    }
}
