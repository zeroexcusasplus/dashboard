using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class MealBuilderRepo : CoreRepo<MealBuilder>, IMealBuilderRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<MealBuilder> _DbSet;
        public MealBuilderRepo(ApplicationDbContext ctx) : base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<MealBuilder>();
        }

        public IEnumerable<MealBuilder> GetAllWithRelationships()
        {
            return _DbSet
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Carbohydrate)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Vegetable)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Protein)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Fat);
        }

        public MealBuilder GetByIdWithRelationships(int id)
        {
            return _DbSet.Where(m=>m.Id == id)
                   .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Carbohydrate)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Vegetable)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Protein)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Fat).FirstOrDefault();
        }

        public IEnumerable<MealBuilder> FindInclude(Expression<Func<MealBuilder, bool>> predicate)
        {
            return _DbSet.Where(predicate).Where(t => t.IsDeleted == false)
                   .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Carbohydrate)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Vegetable)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Protein)
                    .Include(m => m.Meals)
                        .ThenInclude(meals => meals.Fat)
                     .Include(m => m.Customer);
        }

    }
}
