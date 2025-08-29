// FoodDeliveryAna.Repository/IRepository.cs
using FoodDeliveryAna.Domain;
using FoodDeliveryAna.Domain.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace FoodDeliveryAna.Repository;

public interface IRepository<T> where T : BaseEntity
{
    T Insert(T entity);
    T Update(T entity);
    T Delete(T entity);
    E? Get<E>(Expression<Func<T, E>> selector,
              Expression<Func<T, bool>>? predicate = null,
              Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);
    IEnumerable<E> GetAll<E>(Expression<Func<T, E>> selector,
              Expression<Func<T, bool>>? predicate = null,
              Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
              Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);
}

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _db;    // now resolves
    private readonly DbSet<T> _set;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
        _set = _db.Set<T>();
    }

    public T Insert(T e) { _set.Add(e); _db.SaveChanges(); return e; }
    public T Update(T e) { _set.Update(e); _db.SaveChanges(); return e; }
    public T Delete(T e) { _set.Remove(e); _db.SaveChanges(); return e; }

    public E? Get<E>(Expression<Func<T, E>> selector,
        Expression<Func<T, bool>>? predicate = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> q = _set;
        if (include != null) q = include(q);
        if (predicate != null) q = q.Where(predicate);
        return q.Select(selector).FirstOrDefault();
    }

    public IEnumerable<E> GetAll<E>(Expression<Func<T, E>> selector,
        Expression<Func<T, bool>>? predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> q = _set;
        if (include != null) q = include(q);
        if (predicate != null) q = q.Where(predicate);
        if (orderBy != null) q = orderBy(q);
        return q.Select(selector).ToList();
    }
}
