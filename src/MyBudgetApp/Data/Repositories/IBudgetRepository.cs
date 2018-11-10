namespace MyBudgetApp.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using MyBudgetApp.DTO;

    public interface IBudgetRepository
    {
        IQueryable<BudgetDTO> GetMyBudgets(string userId);

        IQueryable<BudgetCategoryDTO> GetBudgetCategories();

        IQueryable<BudgetPreviewDTO> GetBudgetPerCategory(int categoryId);

        Task AddBudget(AddBudgetDTO budgetDTO);
    }
}
