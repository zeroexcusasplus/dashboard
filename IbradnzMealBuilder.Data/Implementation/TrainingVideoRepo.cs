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
    public class TrainingVideoRepo : CoreRepo<TrainingVideos> , ITrainingVideoRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TrainingVideos> _DbSet;
        public TrainingVideoRepo(ApplicationDbContext ctx) : base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<TrainingVideos>();
        }


        public IEnumerable<TrainingVideos> GetAllInclude()
        {
            return _DbSet.Where(c => !c.IsDeleted)
                .Include(c => c.Program);
        }
        public TrainingVideos GetInclude(int id)
        {
            return _DbSet.Where(c => c.Id == id && !c.IsDeleted)
                .Include(c => c.Program)
                .FirstOrDefault();
        }

        public IEnumerable<TrainingVideos> FindInclude(Expression<Func<TrainingVideos, bool>> predicate)
        {
            return _DbSet.Where(predicate).Where(c => !c.IsDeleted)
                .Include(c => c.Program);
        }
    }
}
