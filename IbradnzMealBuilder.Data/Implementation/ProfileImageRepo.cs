using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{
    public class ProfileImageRepo : CoreRepo<ProfileImage>, IProfileImageRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<ProfileImage> _DbSet;
        public ProfileImageRepo(ApplicationDbContext ctx) : base(ctx)
        {
            this._context = ctx;
            this._DbSet = this._context.Set<ProfileImage>();
        }
    }
}
