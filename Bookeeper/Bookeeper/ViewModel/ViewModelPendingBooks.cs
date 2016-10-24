using Bookeeper.DataContext;
using Bookeeper.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookeeper.ViewModel
{
    public class ViewModelPendingBooks : ModelBook
    {
        private ObservableCollection<ModelBook> PendingBooksList;

        public ObservableCollection<ModelBook> GetPendingBooksList
        {
            get
            {
                if (PendingBooksList == null)
                {
                    GetPendingBooks();
                }

                return PendingBooksList;
            }

            set
            {
                PendingBooksList = value;
            }
        }

        public void GetPendingBooks()
        {
            using (var context = new DataContextBook())
            {
                ObservableCollection<ModelBook> model = new ObservableCollection<ModelBook>(context.GetBookList(0));
                PendingBooksList = model;
            }
        }
    }
}
