namespace MyBudgetApp.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IBudgetRepository, BudgetRepository>();

            return services;
        }

        public static IdentityBuilder AddIdentity(this IServiceCollection services, IHostingEnvironment env)
        {
            var isDevelopment = env.IsDevelopment();
            return services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.Password.RequireDigit = !isDevelopment;
                options.Password.RequireLowercase = !isDevelopment;
                options.Password.RequireUppercase = !isDevelopment;
                options.Password.RequireNonAlphanumeric = !isDevelopment;
                options.Password.RequiredLength = 6;
            });
        }
    }
}
