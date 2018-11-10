namespace MyBudgetApp.Data.Models
{
    public class BudgetListCategory
    {
        public int BudgetCategoryId { get; set; }

        public int BudgetListId { get; set; }

        public BudgetCategory BudgetCategory { get; set; }

        public BudgetList BudgetList { get; set; }
    }
}
