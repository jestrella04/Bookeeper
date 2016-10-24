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
    public class ViewModelReadBooks : ModelBook
    {
        private ObservableCollection<ModelBook> ReadBooksList;

        public ObservableCollection<ModelBook> GetReadBooksList
        {
            get
            {
                if (ReadBooksList == null)
                {
                    GetReadBooks();
                }

                return ReadBooksList;
            }

            set
            {
                ReadBooksList = value;
            }
        }

        public void GetReadBooks()
        {
            using (var context = new DataContextBook())
            {
                ObservableCollection<ModelBook> model = new ObservableCollection<ModelBook>(context.GetBookList(1));
                ReadBooksList = model;
            }
        }
    }
}
