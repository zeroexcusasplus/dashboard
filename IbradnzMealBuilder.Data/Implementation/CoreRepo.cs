﻿using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IbradnzMealBuilder.Data.Implementation
{

    public class CoreRepo<TEntity> : ICoreRepo<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Entity> _DbSet;

        public CoreRepo(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._DbSet = this._dbContext.Set<Entity>();
        }

        public void Add(TEntity entity)
        {
            if (entity is Entity)
            {
                (entity as Entity).DateCreated = DateTime.Now;
                (entity as Entity).DateCreatedUtc = DateTime.UtcNow;
                (entity as Entity).DateModified = DateTime.Now;
                (entity as Entity).DateModifiedUtc = DateTime.UtcNow;
                (entity as Entity).IsDeleted = false;
            }

            _dbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(e => e.DateCreated = DateTime.Now);
            entities.ToList().ForEach(e => e.DateCreatedUtc = DateTime.UtcNow);
            entities.ToList().ForEach(e => e.DateModified = DateTime.Now);
            entities.ToList().ForEach(e => e.DateModifiedUtc = DateTime.UtcNow);
            entities.ToList().ForEach(e => e.IsDeleted = false);
            _dbContext.Set<TEntity>().AddRange(entities);
        }

        public TEntity Get(object id)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            if (entity == null) return null;
            if (entity.IsDeleted == false)
                return entity;
            return null;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().Where(t => t.IsDeleted == false).ToList();
        }

        public IEnumerable<TEntity> GetAllWithDelete()
        {
            return _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).Where(t => t.IsDeleted == false);
        }

        public int Count()
        {
            return _dbContext.Set<TEntity>().Where(t => t.IsDeleted == false).Count();
        }

        public void Remove(TEntity entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
                Remove(item);
        }

        public void Update(TEntity entity)
        {
            (entity as Entity).DateModified = DateTime.Now;
            (entity as Entity).DateModifiedUtc = DateTime.UtcNow;
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                Update(entity);
        }

        public void Attach(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
        }
        public void Include(string entityName)
        {
            _dbContext.Set<TEntity>().Include(entityName);
        }

        public void DeleteFromDb(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void DeleteRangeFromDb(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }

    }
}
