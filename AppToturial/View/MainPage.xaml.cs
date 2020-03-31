using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppToturial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            initPicker();
        }

        void initPicker()
        {
            string[] item = { "A", "B", "C" };
           // picker.ItemsSource = item;            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "You clicked me", "ok");
        }
    }
}
