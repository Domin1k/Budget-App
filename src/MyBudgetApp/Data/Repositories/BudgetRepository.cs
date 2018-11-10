namespace MyBudgetApp.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using MyBudgetApp.DTO;
    using MyBudgetApp.Infrastructure.Mappings;

    public class BudgetRepository : IBudgetRepository
    {
        private readonly ApplicationDbContext context;

        public BudgetRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task AddBudget(AddBudgetDTO budgetDTO)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<BudgetCategoryDTO> GetBudgetCategories()
            => this.context.BudgetCategories.Select(Mapper.ToBudgetCategoryDTO);

        public IQueryable<BudgetPreviewDTO> GetBudgetPerCategory(int categoryId)
            => this.context.BudgetItems.Where(bi => bi.BudgetCategoryId == categoryId).Select(Mapper.ToBudgetPreviewDTO);

        public IQueryable<BudgetDTO> GetMyBudgets(string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}
