using Bookeeper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bookeeper.Page
{
    public partial class PageInsertBook : ContentPage
    {
        public PageInsertBook()
        {
            InitializeComponent();
            BindingContext = new ViewModelBook();
        }
    }
}
