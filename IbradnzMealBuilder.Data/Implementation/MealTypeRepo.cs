using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class MealTypeRepo : CoreRepo<MealType>, IMealTypeRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<MealType> _DbSet;
        public MealTypeRepo(ApplicationDbContext ctx): base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<MealType>();
        }

    }
}