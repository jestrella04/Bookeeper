using Bookeeper.Model;
using Bookeeper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bookeeper.Page
{
    public partial class PagePendingBooks : ContentPage
    {
        public PagePendingBooks()
        {
            InitializeComponent();
            BindingContext = new ViewModelPendingBooks();
        }

        private void ClickViewBook(object sender, ItemTappedEventArgs e)
        {
            PendingBooksList.SelectedItem = null;
            var book = e.Item as ModelBook;
            var pageViewBook = new PageViewBook();

            pageViewBook.BindingContext = book;

            ((NavigationPage)this.Parent).PushAsync(pageViewBook);
        }
    }
}
