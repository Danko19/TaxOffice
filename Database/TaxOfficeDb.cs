using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using BLToolkit.Data;
using BLToolkit.Data.DataProvider;
using BLToolkit.Data.Linq;

namespace TaxOffice.Database
{
    public static class TaxOfficeDb
    {
        private static readonly DbManager DbManager;
        static TaxOfficeDb()
        {
            DbManager = new DbManager(new SQLiteDataProvider(), $"Data Source={SourcePath};Version=3;");
        }

        public static IEnumerable<TItem> Select<TItem>(Expression<Func<TItem, bool>> predicate)
            where TItem : class
        {
            return DbManager.GetTable<TItem>().Where(predicate);
        }

        public static void Update<TItem>(Expression<Func<TItem, bool>> predicate, Expression<Func<TItem, TItem>> setter)
            where TItem : class
        {
            DbManager.GetTable<TItem>().Update(predicate, setter);
        }

        public static void Insert<TItem>(Expression<Func<TItem>> setter)
            where TItem : class
        {
            DbManager.GetTable<TItem>().Insert(setter);
        }

        public static void Delete<TItem>(Expression<Func<TItem, bool>> predicate)
            where TItem : class
        {
            DbManager.GetTable<TItem>().Delete(predicate);
        }

        private static string SourcePath => Path.Combine(Environment.CurrentDirectory, "Database", "db.sqlite");
    }
}