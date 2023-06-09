﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Abstract;

namespace WebMvcUI.Models.Reposities.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Entities { get; }

        bool Insert(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
    }
}
