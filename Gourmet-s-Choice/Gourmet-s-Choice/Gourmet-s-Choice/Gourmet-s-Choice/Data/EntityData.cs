using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Data
{
    public class EntityDataInitializer
    {
        public const string ConnectionString = "name=FoodEntitie";
    }

    public class EntityData<T> : EntityDataInitializer where T : class
    {
        private static DbContext Create()
        {
            DbContext context = new DbContext(ConnectionString);
            context.Database.Log = x => Debug.WriteLine(x);
            return context;
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate = null, int startRowIndex = 0,
            int maximumRows = int.MaxValue)
        {
            using (DbContext context = Create())
            {
                IQueryable<T> query = from x in context.Set<T>()
                    select x;
                if (predicate != null)
                    query = query.Where(predicate);
                query = GetOrderedQuery(query);
                if (startRowIndex != 0)
                    query = query.Skip(startRowIndex);
                if (maximumRows != int.MaxValue)
                    query = query.Take(maximumRows);
                return query.ToList();
            }
        }

        protected virtual IQueryable<T> GetOrderedQuery(IQueryable<T> query)
        {
            throw new NotImplementedException("EntityData.GetOrderedQuery");
        }

        public List<T> Get<U>(
            Expression<Func<T, bool>> predicate = null,
            Expression<Func<T, U>> orderBy = null,
            int startRowIndex = 0, int maximumRows = int.MaxValue)
        {
            using (DbContext context = Create())
            {
                IQueryable<T> query = from x in context.Set<T>()
                    select x;
                if (predicate != null)
                    query = query.Where(predicate);
                if (orderBy != null)
                {
                    query = query.OrderBy(orderBy);
                    if (startRowIndex != 0)
                        query = query.Skip(startRowIndex);
                    if (maximumRows != int.MaxValue)
                        query = query.Take(maximumRows);
                }

                return query.ToList();
            }
        }

        public List<S> Select<U, S>(
            Expression<Func<T, S>> selector,
            Expression<Func<T, bool>> predicate = null,
            Expression<Func<T, U>> orderBy = null,
            int startRowIndex = 0, int maximumRows = int.MaxValue)
        {
            using (DbContext context = Create())
            {
                IQueryable<T> query = from x in context.Set<T>()
                    select x;
                if (predicate != null)
                    query = query.Where(predicate);
                if (orderBy != null)
                {
                    query = query.OrderBy(orderBy);
                    if (startRowIndex != 0)
                        query = query.Skip(startRowIndex);
                    if (maximumRows != int.MaxValue)
                        query = query.Take(maximumRows);
                }

                return query.Select(selector).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (DbContext context = Create())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (DbContext context = Create())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (DbContext context = Create())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public int GetCount()
        {
            return GetCount(null);
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using (DbContext context = Create())
            {
                var query = from x in context.Set<T>()
                    select x;
                if (predicate != null)
                    query = query.Where(predicate);
                return query.Count();
            }
        }

        public T GetFirst(Func<T, bool> predicate)
        {
            using (DbContext context = Create())
            {
                //                return context.Set<T>().FirstOrDefault(x => predicate(x));
                return context.Set<T>().FirstOrDefault(predicate);
            }
        }
    }
}