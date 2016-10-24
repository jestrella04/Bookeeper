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
    public class ViewModelBookComment : ModelBookComment
    {
        public ICommand InsertBookComment { get; private set; }
        public ICommand DeleteBookComment { get; private set; }
        public ICommand ClearBookComment { get; private set; }

        public ViewModelBookComment()
        {
            InsertBookComment = new Command(() =>
            {
                ModelBookComment model = new ModelBookComment()
                {
                    BookId = BookId,
                    BookComment = BookComment,
                    //DateAdded = DateTime.Now
                };

                using (var context = new DataContextBookComment())
                {
                    context.InsertBookComment(model);
                }
            });

            DeleteBookComment = new Command(() =>
            {
                ModelBookComment model = new ModelBookComment()
                {
                    BookId = BookId,
                    BookComment = BookComment,
                    //DateAdded = DateAdded
                };

                using (var context = new DataContextBookComment())
                {
                    context.DeleteBookComment(model);
                }
            });

            ClearBookComment = new Command(() =>
            {
                BookComment = string.Empty;
            });
        }
    }
}
