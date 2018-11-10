namespace MyBudgetApp.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MyBudgetApp.Data.Models;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BudgetItem> BudgetItems { get; set; }

        public DbSet<BudgetList> BudgetLists { get; set; }

        public DbSet<BudgetCategory> BudgetCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BudgetListCategory>()
                .HasKey(lc => new { lc.BudgetCategoryId, lc.BudgetListId });

            builder.Entity<BudgetListCategory>()
                .HasOne(bc => bc.BudgetCategory)
                .WithMany(b => b.BudgetListsCategories)
                .HasForeignKey(bc => bc.BudgetCategoryId);

            builder.Entity<BudgetListCategory>()
                .HasOne(bc => bc.BudgetList)
                .WithMany(b => b.BudgetListsCategories)
                .HasForeignKey(bc => bc.BudgetListId);
        }
    }
}
