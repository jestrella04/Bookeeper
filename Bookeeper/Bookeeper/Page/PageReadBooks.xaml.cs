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
    public partial class PageReadBooks : ContentPage
    {
        public PageReadBooks()
        {
            InitializeComponent();
            BindingContext = new ViewModelReadBooks();
        }

        private void ClickViewBook(object sender, ItemTappedEventArgs e)
        {
            ReadBooksList.SelectedItem = null;
            var book = e.Item as ModelBook;
            var pageViewBook = new PageViewBook();

            pageViewBook.BindingContext = book;

            ((NavigationPage)this.Parent).PushAsync(pageViewBook);
        }
    }
}
