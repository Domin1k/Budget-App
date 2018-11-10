namespace MyBudgetApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public static class DbSeeder
    {
        public static void SeedBudgetData(ApplicationDbContext context)
        {
            if (context.BudgetCategories.Any())
            {
                return;
            }

            var predifinedBudget = new Dictionary<string, List<string>>
            {
                { "Food", new List<string>{ "Groceries", "Restaurants", "Pet Food/Treats" } },
                { "House", new List<string>{ "Mortgage", "Rent", "Property Taxes", "Household Repairs" } },
                { "Utilities", new List<string>{ "Electricity", "Water", "Heating", "Garbage", "Phones", "Cable", "Internet" } },
                { "Clothing", new List<string>{ "Adult’s Clothing" } },
                { "Transportation", new List<string>{ "Fuel", "Repairs", "Maintenance" } },
                { "Personal", new List<string>{ "Gym Memberships", "Hair Cuts", "Cosmetics", "Subscriptions" } },
                { "Education", new List<string>{ "Books", "Conferences", "College", "Courses" } },
                { "Savings", new List<string>{ "Emergency Fund", "Save Account", "Other" } },
                { "Gifts", new List<string>{ "Birthday", "Christmas" } },
                { "Fun Money", new List<string>{ "Entertainment", "Games", "Eating Out", "Vacations", "Subscriptions – Such as Netflix." } },
            };
            try
            {
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"---ERROR during Seed---{Environment.NewLine}{ex}");
            }
        }
    }
}
