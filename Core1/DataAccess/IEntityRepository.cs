﻿using Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//new() : new'lenebilir olmalı,
//class : referans tip,
//IEntity : 
namespace Core1.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T , bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
