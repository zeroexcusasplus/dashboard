using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class MealRepo : CoreRepo<Meal>, IMealRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Meal> _DbSet;
        public MealRepo(ApplicationDbContext ctx) : base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<Meal>();
        }
    }
}
