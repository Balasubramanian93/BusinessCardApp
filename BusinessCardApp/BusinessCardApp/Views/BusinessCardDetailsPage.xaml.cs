using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusinessCardApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusinessCardDetailsPage : ContentPage
    {
        public BusinessCardDetailsPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("sUCCESS", "Added Successfully!!", "OK");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}