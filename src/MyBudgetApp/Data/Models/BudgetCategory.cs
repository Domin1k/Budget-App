namespace MyBudgetApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BudgetCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<BudgetItem> BudgetItems { get; set; } = new List<BudgetItem>();

        public List<BudgetListCategory> BudgetListsCategories { get; set; } = new List<BudgetListCategory>();
    }
}
