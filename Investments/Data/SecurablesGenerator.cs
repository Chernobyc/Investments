namespace Investments.Data
{
    public static class SecurablesGenerator
    {
        public static void GenerateSecurables(DataContext context)
        {
            context.Securables.Add(new Securable { Ticker = "EUR" , Name = "Euro"      });
            context.Securables.Add(new Securable { Ticker = "MSFT", Name = "Microsoft" });
            context.Securables.Add(new Securable { Ticker = "AAPL", Name = "Apple"     });
            context.Securables.Add(new Securable { Ticker = "GOOG", Name = "Google"    });
        }
    }
}