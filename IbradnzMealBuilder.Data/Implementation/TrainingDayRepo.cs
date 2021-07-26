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
    public class TrainingDayRepo : CoreRepo<TrainingDay>, ITrainingDayRepo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TrainingDay> _dbSet;
        public TrainingDayRepo(ApplicationDbContext ctx):base(ctx)
        {
            _dbContext = ctx;
            _dbSet = _dbContext.Set<TrainingDay>();
        }


        public IEnumerable<TrainingDay> GetAllInclude()
        {
            return _dbSet.Where(c => !c.IsDeleted)
                .Include(c => c.T_Program);
        }
        public TrainingDay GetInclude(int id)
        {
            return _dbSet.Where(c => c.Id == id && !c.IsDeleted)
                .Include(c => c.T_Program)
                .FirstOrDefault();
        }

        public IEnumerable<TrainingDay> FindInclude(Expression<Func<TrainingDay, bool>> predicate)
        {
            return _dbSet.Where(predicate).Where(c => !c.IsDeleted)
                .Include(c => c.T_Program);
        }
    }
}
