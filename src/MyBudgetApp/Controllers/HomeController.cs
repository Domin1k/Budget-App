namespace MyBudgetApp.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using MyBudgetApp.Data.Repositories;
    using MyBudgetApp.ViewModels;
    using MyBudgetApp.ViewModels.Budget;

    public class HomeController : Controller
    {
        private readonly IBudgetRepository repository;

        public HomeController(IBudgetRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Add(AddBudgetViewModel model)
        {
            if (model == null)
            {
                var categories = await this.repository.GetBudgetCategories().ToListAsync();

                model = new AddBudgetViewModel
                {
                    BudgetCategories = categories.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name}).ToList(),
                };
            }
            else
            {
                var budgetItems = await this.repository.GetBudgetPerCategory(model.SelectedCategoryId).ToListAsync();
                model.BudgetItems = budgetItems.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Text }).ToList();
            }

            return this.View(model);
        }

        [HttpGet]
        public IActionResult Index() => this.View();

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
