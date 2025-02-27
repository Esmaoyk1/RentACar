﻿using Core.Entities;
using Core.Utils.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
    }

}


//Bu yapı, aynı CRUD işlemlerini farklı türler için tekrar etmeden kullanmayı sağlar, böylece kod tekrarı azalır ve daha esnek bir veri erişim katmanı oluşur.





