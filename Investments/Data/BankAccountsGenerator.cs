namespace Investments.Data
{
    public static class BankAccountsGenerator
    {
        public static void GenerateBankAccounts(DataContext context)
        {
            var swed = context.Institutions.GetByName("Swedbank");
            var lhv = context.Institutions.GetByName("LHV");

            context.Accounts.Add(new Account { Name = "Põhikonto", Institution = swed, Type = AccountTypeEnum.BankAccount });
            context.Accounts.Add(new Account { Name = "LHV tavakonto", Institution = lhv, Type = AccountTypeEnum.BankAccount });
            context.Accounts.Add(new Account { Name = "Aktsiad", Institution = lhv, Type = AccountTypeEnum.StockAccount });
        }
    }
}
