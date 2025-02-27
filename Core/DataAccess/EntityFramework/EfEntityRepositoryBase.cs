﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(TEntity entity)
    {
        //using anahtar kelimesi, DbContext nesnesinin doğru ve güvenli bir şekilde yönetilmesini sağlamak için kullanılmıştır.,
        //EntityEntry nesnesini kullanarak varlığın durumunu "Deleted" olarak işaretler ve ardından değişiklikleri veri tabanına kaydeder.
        using (TContext context = new TContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using (TContext context = new TContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        using (TContext context = new TContext())
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }
    }

    public void Update(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

//Bu sınıfın amacı, her varlık sınıfı için CRUD işlemlerini ayrı ayrı yazmak yerine tek bir yerde toplamak ve kod tekrarını azaltmaktır. Örneğin, Brand, Car, Model gibi sınıflar için ayrı ayrı CRUD işlemleri yazmak yerine, bu sınıfı kullanarak tüm varlıklar için temel veri erişim işlemleri tek bir yapı ile yapılabilir.