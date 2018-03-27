using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using static System.Activator;

namespace ScheduleLogic.Fakes
{
    public class FakeDbSet<T> : IDbSet<T>
        where T : class
    {
        public FakeDbSet()
        {
            Local = new ObservableCollection<T>();
            Query = Local.AsQueryable();
        }


        public IEnumerator<T> GetEnumerator()
        {
            return Local.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression     Expression  => Query.Expression;
        public Type           ElementType => Query.ElementType;
        public IQueryProvider Provider    => Query.Provider;

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException("Derive from FakeDbSet<T> and override Find");
        }

        public T Add(T entity)
        {
            Local.Add(entity);
            return entity;
        }

        public T Remove(T entity)
        {
            Local.Remove(entity);
            return entity;
        }

        public T Attach(T entity)
        {
            Local.Add(entity);
            return entity;
        }

        public T Create() => CreateInstance<T>();

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T =>
            CreateInstance<TDerivedEntity>();

        public ObservableCollection<T> Local { get; }

        public IQueryable Query { get; set; }
    }
}