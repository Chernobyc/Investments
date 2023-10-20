using System;

namespace Investments.Data
{
    public static class TransactionsGenerator
    {
        public static void GenerateTransactions(DataContext context)
        {
            context.Transactions.Add(new Transaction { Name = context.Securables[2] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-04-10 17:00:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-04-14 18:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[1] , Type = TransactionTypeEnum.Sell , Time = DateTime.Parse("2023-04-19 15:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[2] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-04-21 12:30:00") });
            context.Transactions.Add(new Transaction { Name = context.Securables[3] , Type = TransactionTypeEnum.Buy , Time = DateTime.Parse("2023-05-26 08:29:00") });
           /* 
            context.Transactions.Add(new Transaction { Name = "18.05.2023 MSFT Buy" , Time = DateTime.Parse("2023-05-18 19:10:00") });
            context.Transactions.Add(new Transaction { Name = "23.05.2023 MSFT Buy" , Time = DateTime.Parse("2023-05-23 16:50:00") });
            context.Transactions.Add(new Transaction { Name = "28.05.2023 GOOG Sell", Time = DateTime.Parse("2023-05-28 13:47:00") });
            context.Transactions.Add(new Transaction { Name = "02.06.2023 AAPL Buy" , Time = DateTime.Parse("2023-06-02 21:20:00") });
            context.Transactions.Add(new Transaction { Name = "19.06.2023 AAPL Sell", Time = DateTime.Parse("2023-06-19 18:10:00") });
            context.Transactions.Add(new Transaction { Name = "26.06.2023 GOOG Buy" , Time = DateTime.Parse("2023-06-26 15:59:00") });
            context.Transactions.Add(new Transaction { Name = "29.06.2023 MSFT Sell", Time = DateTime.Parse("2023-06-29 10:20:00") });
           */
           /*
            * 0 eur
            * 1 msft
            * 2 aapl
            * 3 goog
            */
        }
    }
}
