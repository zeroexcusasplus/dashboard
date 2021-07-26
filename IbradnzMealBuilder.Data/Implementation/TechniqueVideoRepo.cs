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
    public class TechniqueVideoRepo : CoreRepo<TechniqueVideo>, ITechniqueVideoRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TechniqueVideo> _DbSet;
        public TechniqueVideoRepo(ApplicationDbContext ctx): base(ctx)
        {
            _context = ctx;
            _DbSet = _context.Set<TechniqueVideo>();
        }
        public TechniqueVideo GetInclude(int id)
        {
            return _DbSet.Where(c => c.Id == id && !c.IsDeleted)
                .Include(c => c.Muscle_Group)
                .FirstOrDefault();
        }

        public IEnumerable<TechniqueVideo> FindInclude(Expression<Func<TechniqueVideo, bool>> predicate)
        {
            return _DbSet.Where(predicate).Where(c => !c.IsDeleted)
                .Include(c => c.Muscle_Group);
        }
    }
}
