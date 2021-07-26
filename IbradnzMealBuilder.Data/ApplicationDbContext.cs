 using System;
using System.Collections.Generic;
using System.Text;
using IbradnzMealBuilder.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IbradnzMealBuilder.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
    
            base.OnModelCreating(builder);
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<MealType> MealType { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<MealBuilder> MealBuilder { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<TrainingVideos> TrainingVideos { get; set; }
        public DbSet<ProfileImage> ProfileImage { get; set; }
        public DbSet<TechniqueVideo> TechniqueVideo { get; set; }
        public DbSet<LiveZoom> LiveZoom { get; set; }
        public DbSet<TrainingDay> TrainingDay { get; set; }
        public DbSet<CountryPhoneCode> CountryPhoneCode { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Training_Program> Program { get; set; }
        public DbSet<Muscle_Group> MuscleGroup { get; set; }
    }
}
