using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class ProgramRepo : CoreRepo<Training_Program>, IProgramRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Training_Program> _dbSet;
        public ProgramRepo(ApplicationDbContext ctx):base(ctx)
        {
            _context = ctx;
            _dbSet = _context.Set<Training_Program>();
        }
    }
}
