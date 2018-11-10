namespace MyBudgetApp.Infrastructure.Mappings
{
    using System;
    using System.Linq.Expressions;
    using MyBudgetApp.Data.Models;
    using MyBudgetApp.DTO;

    public static class Mapper
    {
        public static Expression<Func<BudgetCategory, BudgetCategoryDTO>> ToBudgetCategoryDTO => entity => new BudgetCategoryDTO { Id = entity.Id, Name = entity.Name };

        public static Expression<Func<BudgetItem, BudgetPreviewDTO>> ToBudgetPreviewDTO => entity => new BudgetPreviewDTO { Id = entity.Id, Text = entity.Text };
    }
}
