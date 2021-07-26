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
    public class CustomerRepo : CoreRepo<Customer>, ICustomerRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Customer> _DbSet;

        public CustomerRepo(ApplicationDbContext ctx) : base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<Customer>();
        }

        public Customer GetInclude(int id)
        {
            return _DbSet.Where(c => c.Id == id && !c.IsDeleted)
                .Include(c => c.Subscriptions)
                .FirstOrDefault();
        }

        public IEnumerable<Customer> FindInclude(Expression<Func<Customer,bool>> predicate)
        {
            return _DbSet.Where(predicate).Where(c => !c.IsDeleted)
                .Include(c => c.Subscriptions);
        }
    }
}
