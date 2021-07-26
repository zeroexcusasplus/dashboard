using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class CountryPhoneCodeRepo : CoreRepo<CountryPhoneCode>, ICountryPhoneCodeRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<CountryPhoneCode> _dbSet;
        public CountryPhoneCodeRepo(ApplicationDbContext ctx):base(ctx)
        {
            _context = ctx;
            _dbSet = _context.Set<CountryPhoneCode>();
        }
    }
}
