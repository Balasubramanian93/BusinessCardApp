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
    public partial class BusinessCardList : ContentPage
    {
        public BusinessCardList()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BusinessCardRequestPage());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BusinessCardDetailsPage());
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new BusinessCardDetailsPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BusinessCardRequestPage());
        }
    }
}