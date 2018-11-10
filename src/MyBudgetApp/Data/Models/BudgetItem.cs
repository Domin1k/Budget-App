namespace MyBudgetApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BudgetItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Text { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public decimal TotalSpent { get; set; }

        public int BudgetCategoryId { get; set; }

        [ForeignKey("BudgetCategoryId")]
        public BudgetCategory BudgetCategory { get; set; }
    }
}
