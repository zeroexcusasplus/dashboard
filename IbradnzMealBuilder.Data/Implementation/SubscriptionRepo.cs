using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class SubscriptionRepo : CoreRepo<Subscription>, ISubscriptionRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Subscription> _DbSet;
        public SubscriptionRepo(ApplicationDbContext ctx) : base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<Subscription>();
        }

    }
}
