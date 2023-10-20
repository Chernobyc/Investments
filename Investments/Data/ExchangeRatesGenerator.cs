using System;

namespace Investments.Data
{
    public static class ExchangeRatesGenerator 
    {
        public static void GenerateExchangeRates(DataContext context)
        {
            var eur = context.Securables.GetByTicker("EUR");
            var msft = context.Securables.GetByTicker("MSFT");
            var aapl = context.Securables.GetByTicker("AAPL");
            var goog = context.Securables.GetByTicker("GOOG");

            Random random = new Random();

            decimal msftRate = 331.32m; // Начальное значение курса
            decimal msftVolatility = 0.06m; // Волатильность
            
            //msft rates
            for (int i = 90; i >= 1; i--)
            {
                DateTime date = DateTime.Now.AddDays(-i);
                decimal randomNumber = (decimal)random.NextDouble() * 2 - 1; // Генерирует случайное число между -1 и 1
                msftRate *= (1 + msftVolatility * randomNumber); // Моделирует изменение курса

                context.ExchangeRates.Add(new ExchangeRate { Date = date, Rate = msftRate, From = msft, To = eur });
            }

            decimal aaplRate = 175.46m;
            decimal aaplVolatility = 0.045m;
            //aapl rates
            for (int i = 90; i >= 1; i--)
            {
                DateTime date = DateTime.Now.AddDays(-i);
                decimal randomNumber = (decimal)random.NextDouble() * 2 - 1; // generates a random num between -1 and 1
                aaplRate *= (1 + aaplVolatility * randomNumber); // simulates rate change

                context.ExchangeRates.Add(new ExchangeRate { Date = date, Rate = msftRate, From = aapl, To = eur });
            }

            decimal googRate = 137.75m;
            decimal googVolatility = 0.0678m;
            //goog rates
            for (int i = 90; i >= 1; i--)
            {
                DateTime date = DateTime.Now.AddDays(-i);
                decimal randomNumber = (decimal)random.NextDouble() * 2 - 1;
                googRate *= (1 + googVolatility * randomNumber);

                context.ExchangeRates.Add(new ExchangeRate { Date = date, Rate = msftRate, From = goog, To = eur });
            }
            // oli context.ExchangeRates.Add(new ExchangeRate { Date = DateTime.Now.AddDays(-90), Rate = 261.55m, From = msft, To = eur });
        }
    }
}
