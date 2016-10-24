using Bookeeper.Model;
using Bookeeper.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bookeeper.ViewModel
{
    public class ViewModelBook : ModelBook 
    {
        public ICommand GetBook { get; set; }
        public ICommand InsertBook { get; set; }
        public ICommand UpdateBook { get; set; }
        public ICommand DeleteBook { get; set; }
        public ICommand ClearBook { get; set; }

        public ViewModelBook()
        {
            GetBook = new Command(() =>
            {
                ModelBook model = new ModelBook()
                {
                    BookId = BookId,
                    BookTitle = BookTitle,
                    BookAuthor = BookAuthor,
                    BookStatus = BookStatus
                    //DateAdded = DateAdded,
                    //DateRead = DateRead
                };

                using (var context = new DataContextBook())
                {
                    context.GetBook(BookId);
                }
            });

            InsertBook = new Command(() =>
            {
                ModelBook model = new ModelBook()
                {
                    BookId = BookId,
                    BookTitle = BookTitle,
                    BookAuthor = BookAuthor,
                    BookStatus = BookStatus
                    //DateAdded = DateAdded,
                    //DateRead = DateRead
                };

                using (var context = new DataContextBook())
                {
                    context.InsertBook(model);
                }
            });

            UpdateBook = new Command(() =>
            {
                ModelBook model = new ModelBook()
                {
                    BookId = BookId,
                    BookTitle = BookTitle,
                    BookAuthor = BookAuthor,
                    BookStatus = BookStatus
                    //DateAdded = DateAdded,
                    //DateRead = DateRead
                };

                using (var context = new DataContextBook())
                {
                    context.UpdateBook(model);
                }
            });

            DeleteBook = new Command(() =>
            {
                ModelBook model = new ModelBook()
                {
                    BookId = BookId,
                    BookTitle = BookTitle,
                    BookAuthor = BookAuthor,
                    BookStatus = BookStatus
                    //DateAdded = DateAdded,
                    //DateRead = DateRead
                };

                using (var context = new DataContextBook())
                {
                    context.DeleteBook(model);
                }
            });

            ClearBook = new Command(() =>
            {
                BookId = BookId;
                BookTitle = string.Empty;
                BookAuthor = string.Empty;
                BookStatus = 0;
                //DateAdded = DateTime.Now;
                //DateRead = DateTime.Now;
            });
        }
    }
}
