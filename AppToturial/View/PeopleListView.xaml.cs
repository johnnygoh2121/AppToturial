using AppToturial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppToturial.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleListView : ContentPage
    {
        public PeopleListView()
        {
            InitializeComponent();
            BindingContext = new PeopleListVM(Navigation);
        }
    }
}