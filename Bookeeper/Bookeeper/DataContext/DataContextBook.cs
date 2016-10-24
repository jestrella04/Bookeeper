using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using Bookeeper.Model;

namespace Bookeeper.DataContext
{
    public class DataContextBook : IDisposable
    {
        private SQLiteConnection conn;

        public DataContextBook()
        {
            var config = DependencyService.Get<IConfiguration>();

            conn = new SQLiteConnection(config.platform, Path.Combine(config.dir, "bookeeper.db3"));

            conn.CreateTable<ModelBook>();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public void InsertBook(ModelBook book)
        {
            conn.Insert(book);
        }

        public void UpdateBook(ModelBook book)
        {
            conn.Update(book);
        }

        public void DeleteBook(ModelBook book)
        {
            conn.Delete(book);
        }

        public ModelBook GetBook(int bookId)
        {
            return conn.Table<ModelBook>().FirstOrDefault(v => v.BookId == bookId);
        }

        public List<ModelBook> GetBookList(int statusId = 0)
        {
            return conn.Table<ModelBook>().Where(v => v.BookStatus == statusId).ToList();
        }
    }
}
