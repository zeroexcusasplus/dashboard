using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class LiveZoomRepo : CoreRepo<LiveZoom>, ILiveZoomRepo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<LiveZoom> _DbSet;
        public LiveZoomRepo(ApplicationDbContext ctx):base(ctx)
        {
            _dbContext = ctx;
            _DbSet = _dbContext.Set<LiveZoom>();
        }
    }
}
