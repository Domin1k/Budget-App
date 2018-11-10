namespace MyBudgetApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNetCore.Identity;

    public class BudgetList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Title { get; set; }
        
        [Range(0, int.MaxValue)]
        public decimal RemainingBudget { get; set; }

        [Range(0, int.MaxValue)]
        public decimal AvailableBudget { get; set; }

        [Required]
        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public IdentityUser Creator { get; set; }

        public List<BudgetListCategory> BudgetListsCategories { get; set; } = new List<BudgetListCategory>();
    }
}
