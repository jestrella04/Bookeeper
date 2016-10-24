using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bookeeper.Page
{
    public partial class PageMain : ContentPage
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void ClickInsertBook(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageInsertBook());
        }

        private void ClickReadBooks(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageReadBooks());
        }

        private void ClickPendingBooks(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PagePendingBooks());
        }
    }
}
