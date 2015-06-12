using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace Collector.Data
{
    public class BaseData<T>
        where T : class
    {
        protected Database defaultDB = new Database("Collector");

        public bool IsNew(T item)
        {
            return defaultDB.IsNew<T>(item);
        }

        public object Insert(T item)
        {
            return defaultDB.Insert<T>(item);
        }

        public void Save(T item)
        {
            defaultDB.Save<T>(item);
        }

        public int Update(T item)
        {
            return defaultDB.Update(item);
        }

        public int Update(IEnumerable<string> columns, T item)
        {
            return defaultDB.Update(item, columns);
        }

        public int Update(string sql, params object[] args)
        {
            return defaultDB.Update<T>(sql, args);
        }

        public int Update(Sql sql) { return defaultDB.Update<T>(sql); }

        public int Delete(T item) { return defaultDB.Delete(item); }

        public int Delete(string sql, params object[] args) { return defaultDB.Delete<T>(sql, args); }
        public int Delete(Sql sql) { return defaultDB.Delete<T>(sql); }
        public int Delete(object primaryKey) { return defaultDB.Delete<T>(primaryKey); }

        public bool Exists(object primaryKey) { return defaultDB.Exists<T>(primaryKey); }
        //public bool Exists(string sql, params object[] args) { return defaultDB.Exists<T>(sql, args); }

        public T SingleOrDefault(object primaryKey) { return defaultDB.SingleOrDefaultById<T>(primaryKey); }
        public T SingleOrDefault(string sql, params object[] args) { return defaultDB.SingleOrDefault<T>(sql, args); }
        public T SingleOrDefault(Sql sql) { return defaultDB.SingleOrDefault<T>(sql); }

        public T FirstOrDefault(string sql, params object[] args) { return defaultDB.FirstOrDefault<T>(sql, args); }
        public T FirstOrDefault(Sql sql) { return defaultDB.FirstOrDefault<T>(sql); }
        public T Single(object primaryKey) { return defaultDB.SingleOrDefaultById<T>(primaryKey); }
        public T Single(string sql, params object[] args) { return defaultDB.Single<T>(sql, args); }
        public T Single(Sql sql) { return defaultDB.Single<T>(sql); }
        public T First(string sql, params object[] args) { return defaultDB.First<T>(sql, args); }
        public T First(Sql sql) { return defaultDB.First<T>(sql); }
        public List<T> Fetch(string sql, params object[] args) { return defaultDB.Fetch<T>(sql, args); }
        public List<T> Fetch(Sql sql) { return defaultDB.Fetch<T>(sql); }
        public List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return defaultDB.Fetch<T>(page, itemsPerPage, sql, args); }
        public List<T> Fetch(long page, long itemsPerPage, Sql sql) { return defaultDB.Fetch<T>(page, itemsPerPage, sql); }
        public List<T> SkipTake(long skip, long take, string sql, params object[] args) { return defaultDB.SkipTake<T>(skip, take, sql, args); }
        public List<T> SkipTake(long skip, long take, Sql sql) { return defaultDB.SkipTake<T>(skip, take, sql); }
        public Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return defaultDB.Page<T>(page, itemsPerPage, sql, args); }
        public Page<T> Page(long page, long itemsPerPage, Sql sql) { return defaultDB.Page<T>(page, itemsPerPage, sql); }
        public IEnumerable<T> Query(string sql, params object[] args) { return defaultDB.Query<T>(sql, args); }
        public IEnumerable<T> Query(Sql sql) { return defaultDB.Query<T>(sql); }
    }
}
