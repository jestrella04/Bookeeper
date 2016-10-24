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
    public class ViewModelBookCommentList : ModelBookComment
    {
        private ObservableCollection<ModelBookComment> BookCommentList;

        public ObservableCollection<ModelBookComment> GetBookCommentList
        {
            get
            {
                if (BookCommentList == null)
                {
                    GetBookComments();
                }

                return BookCommentList;
            }

            set
            {
                BookCommentList = value;
            }
        }

        public void GetBookComments()
        {
            using (var context = new DataContextBookComment())
            {
                ObservableCollection<ModelBookComment> model = new ObservableCollection<ModelBookComment>(context.GetBookCommentList(0));
                BookCommentList = model;
            }
        }
    }
}
