using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class MuscleGroupRepo : CoreRepo<Muscle_Group>, IMuscleGroupRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Muscle_Group> _dbSet;
        public MuscleGroupRepo(ApplicationDbContext ctx):base(ctx)
        {
            _context = ctx;
            _dbSet = _context.Set<Muscle_Group>();
        }

    }
}
