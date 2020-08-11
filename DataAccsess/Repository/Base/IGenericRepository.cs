﻿using DataAccsess.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Repository.Base
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        void Save(T entity);
        T Get(Guid id);
        void Update(T entity);
        void Delete(Guid id);
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
