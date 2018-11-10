namespace MyBudgetApp.ViewModels.Budget
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AddBudgetViewModel
    {
        public int SelectedCategoryId { get; set; }

        public List<SelectListItem> BudgetCategories { get; set; }

        public int[] SelectedBudgetItemsId { get; set; }

        public List<SelectListItem> BudgetItems { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }
    }
}
