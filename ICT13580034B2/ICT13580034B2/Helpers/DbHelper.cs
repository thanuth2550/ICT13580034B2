using ICT13580034B2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT13580034B2.Help
{
    public class DbHelper
    {
        SQLiteConnection db;

        public DbHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();
        }

        public int AddProduct(Product product)
        {
            db.Insert(product);
            return product.Id;
        }

        public List<Product> GetProducts()
        {
            return db.Table<Product>().ToList();
        }

        public int UpdateProduct(Product product)
        {
            return db.Update(product);
        }

        public int DeleteProduct(Product product)
        {
            return db.Delete(product);
        }
    }
}
