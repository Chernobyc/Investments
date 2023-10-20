namespace Investments.Data
{
    public static class InstitutionsGenerator
    {
        public static void GenerateInstitutions(DataContext context)
        {
            context.Institutions.Add(new Institution { Name = "LHV" });
            context.Institutions.Add(new Institution { Name = "Swedbank" });
            context.Institutions.Add(new Institution { Name = "Binance" });
        }
    }
}