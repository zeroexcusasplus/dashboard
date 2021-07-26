using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class FaqRepo : CoreRepo<Faq>, IFaqRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Faq> _dbSet;
        public FaqRepo(ApplicationDbContext ctx):base(ctx)
        {
            _context = ctx;
            _dbSet = _context.Set<Faq>();
        }
    }
}
