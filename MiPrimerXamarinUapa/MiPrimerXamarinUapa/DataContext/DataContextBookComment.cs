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
    public class DataContextBookComment : IDisposable
    {
        private SQLiteConnection conn;

        public DataContextBookComment()
        {
            var config = DependencyService.Get<IConfiguration>();
            conn = new SQLiteConnection(config.platform, Path.Combine(config.dir, "bookeeper.db3"));

            conn.CreateTable<ModelBookComment>();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public void InsertBookComment(ModelBookComment bookComment)
        {
            conn.Insert(bookComment);
        }


        public void DeleteBookComment(ModelBookComment bookComment)
        {
            conn.Delete(bookComment);
        }

        public List<ModelBookComment> GetBookCommentList(int bookId)
        {
            return conn.Table<ModelBookComment>().Where(v => v.BookId == bookId).ToList();
        }
    }
}
