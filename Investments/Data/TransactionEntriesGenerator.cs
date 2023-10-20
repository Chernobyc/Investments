using System;
using System.Linq;

namespace Investments.Data
{
    public static class TransactionEntriesGenerator
    {
        public static void GenerateTransactionEntries(DataContext context)
        {
            var pohikonto = context.Accounts[0]; // oli 1
            var lhv = context.Accounts[1]; // oli 0 
            var aktsiadLhv = context.Accounts[2];

            /*
            1 eur
            2 msft
            3 aapl
            4 goog
            */

            // Ülekanne Swed => LHV 50 EUR
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "123456789001",
                Time = DateTime.Now.AddDays(-90),
                OwningAccount = pohikonto,
                OtherAccount = lhv,
                Amount = 50,
                Securable = context.Securables[0], // EUR
                Type = TransactionTypeEnum.Transfer, // Tavaline ülekanne
                Transaction = context.Transactions[0],
                Description = "Investeerimiseks"
            });

            // Swedis teenustasu
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492349",
                Time = DateTime.Parse("2023-04-10 17:00:00"),
                OwningAccount = pohikonto,
                Amount = 0.40m,
                Securable = context.Securables[0], // EUR
                Type = TransactionTypeEnum.ServiceFee, // Tavaline ülekanne
                Transaction = context.Transactions[0],
                Description = "Teenustasu"
            });

            // Ülekanne LHV tavakonto => LHV väärtpaberikonto
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "56634563465456",
                Time = DateTime.Parse("2023-04-10 17:05:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 50,
                Securable = context.Securables[0], // EUR
                Type = TransactionTypeEnum.Transfer, // Tavaline ülekanne
                Transaction = context.Transactions[0],
                Description = "MSFT ostmiseks"
            });

            // Microsofti aktsia ostmine (eurod välja)
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "7142234234",
                Time = DateTime.Parse("2023-04-10 17:07:00"),
                OwningAccount = aktsiadLhv,
                Amount = 45,
                Securable = context.Securables[0], // EUR
                Type = TransactionTypeEnum.Buy, // Tavaline ülekanne
                Transaction = context.Transactions[0],
                Description = "Ostuorder NY388473"
            });

            // Microsofti aktsia ostmine (Microsofti aktsiad sisse)
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "7142234234",
                Time = DateTime.Parse("2023-04-10 17:07:00"),
                OwningAccount = aktsiadLhv,
                //ToAccount = Accounts[2], // Väärtpaberikonto LHV-s
                Amount = 0.171m,
                Securable = context.Securables[1], // Microsoft
                Type = TransactionTypeEnum.Buy, // Tavaline ülekanne
                Transaction = context.Transactions[0],
                Description = "Ostuorder NY388473"
            });

            // Teenustasu LHV-s aktsiate ostmise eest
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492349",
                Time = DateTime.Parse("2023-04-10 17:07:00"),
                OwningAccount = aktsiadLhv,
                //ToAccount = Accounts[0], // Tavaline konto LHV-s
                Amount = 5,
                Securable = context.Securables[0], // EUR
                Type = TransactionTypeEnum.ServiceFee, // Teenustasu
                Transaction = context.Transactions[0],
                Description = "Teenustasu"
            });

            //1
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492301",
                Time = DateTime.Parse("2023-04-10 17:00:00"),
                OwningAccount = aktsiadLhv,
                OtherAccount = lhv,
                Amount = 15,
                Securable = context.Securables[2], // Apple
                Type = TransactionTypeEnum.Sell, // Müümine
                Transaction = context.Transactions[1],
                Description = "AAPL ostmine"
            });

            //2
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492302",
                Time = DateTime.Parse("2023-04-15 16:10:00"),
                OwningAccount = lhv,
                Amount = 77,
                Securable = context.Securables[0], // EUR
                Type = TransactionTypeEnum.Transfer, // Teenustasu
                Transaction = context.Transactions[2],
                Description = "Teenustasu"
            });

            //3
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492303",
                Time = DateTime.Parse("2023-04-16 12:17:00"),
                OwningAccount = lhv,
                Amount = 37,
                Securable = context.Securables[3], // Google
                Type = TransactionTypeEnum.Buy,    // Ostmine
                Transaction = context.Transactions[0],
                Description = "Teenustasu"
            });

            //4
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492304",
                Time = DateTime.Parse("2023-04-19 07:50:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 150,
                Securable = context.Securables[2],
                Type = TransactionTypeEnum.Transfer,
                Transaction = context.Transactions[2],
                Description = "Tavaline ülekanne"
            });

            //5
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492305",
                Time = DateTime.Parse("2023-04-23 15:40:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 50,
                Securable = context.Securables[3],
                Type = TransactionTypeEnum.Transfer,
                Transaction = context.Transactions[3],
                Description = "Tavaline ülekanne"
            });

            //6
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492306",
                Time = DateTime.Parse("2023-04-26 19:20:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 29,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.CurrencyExchange,
                Transaction = context.Transactions[3],
                Description = "Valuuta vahetus"
            });

            //7
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492307",
                Time = DateTime.Parse("2023-04-30 17:10:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 10,
                Securable = context.Securables[2],
                Type = TransactionTypeEnum.Transfer,
                Transaction = context.Transactions[1],
                Description = "Tavaline ülekanne"
            });

            //8
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492308",
                Time = DateTime.Parse("2023-05-01 12:50:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 50,
                Securable = context.Securables[3],
                Type = TransactionTypeEnum.Transfer,
                Transaction = context.Transactions[3],
                Description = "Tavaline ülekanne"
            });

            //9
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492309",
                Time = DateTime.Parse("2023-05-01 12:50:00"),
                OwningAccount = lhv,
                Amount = 90,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.Sell,
                Transaction = context.Transactions[3],
                Description = "Tavaline ülekanne"
            });

            //uued

            //10
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492310",
                Time = DateTime.Parse("2023-05-03 19:40:00"),
                OwningAccount = lhv,
                Amount = 99,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.Sell,
                Transaction = context.Transactions[3],
                Description = "Valuuta vahetus"
            });

            //11
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492311",
                Time = DateTime.Parse("2023-05-06 17:10:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 150,
                Securable = context.Securables[2],
                Type = TransactionTypeEnum.Transfer,
                Transaction = context.Transactions[3],
                Description = "Aktsiade ülekanne"
            });

            //12
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492312",
                Time = DateTime.Parse("2023-05-08 12:15:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 90,
                Securable = context.Securables[3],
                Type = TransactionTypeEnum.Buy,
                Transaction = context.Transactions[3],
                Description = "Google aktsiade ostmine"
            });

            //13
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492313",
                Time = DateTime.Parse("2023-05-10 17:40:00"),
                OwningAccount = lhv,
                Amount = 40,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.ServiceFee,
                Transaction = context.Transactions[3],
                Description = "Teenustasu"
            });

            //14
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492314",
                Time = DateTime.Parse("2023-05-13 13:20:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 120,
                Securable = context.Securables[2],
                Type = TransactionTypeEnum.Sell,
                Transaction = context.Transactions[3],
                Description = "Apple aktsiade muumine"
            });

            //15
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492315",
                Time = DateTime.Parse("2023-05-15 10:30:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 80,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.Transfer,
                Transaction = context.Transactions[3],
                Description = "Tavaline ülekanne"
            });

            //16
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492316",
                Time = DateTime.Parse("2023-05-18 12:50:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 90,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.Sell,
                Transaction = context.Transactions[3],
                Description = "Tavaline ülekanne"
            });

            //17
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492317",
                Time = DateTime.Parse("2023-05-21 13:10:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 129,
                Securable = context.Securables[3],
                Type = TransactionTypeEnum.Buy,
                Transaction = context.Transactions[3],
                Description = "Google ostmine"
            });

            //18
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492318",
                Time = DateTime.Parse("2023-05-24 15:50:00"),
                OwningAccount = lhv,
                Amount = 60,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.CurrencyExchange,
                Transaction = context.Transactions[3],
                Description = "Aktsiade ülekanne"
            });

            //19
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492319",
                Time = DateTime.Parse("2023-05-26 16:45:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 120,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.Sell,
                Transaction = context.Transactions[3],
                Description = "Microsoft aktsiade muumine"
            });

            //20
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492320",
                Time = DateTime.Parse("2023-05-30 19:20:00"),
                OwningAccount = lhv,
                Amount = 140,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.Buy,
                Transaction = context.Transactions[3],
                Description = "Microsoft aktsiade ostmine"
            });

            pohikonto.Entries.AddRange(context.TransactionEntries.Where(t => t.OwningAccount == pohikonto));
            lhv.Entries.AddRange(context.TransactionEntries.Where(t => t.OwningAccount == lhv));
            aktsiadLhv.Entries.AddRange(context.TransactionEntries.Where(t => t.OwningAccount == aktsiadLhv));
        }
    }
}
