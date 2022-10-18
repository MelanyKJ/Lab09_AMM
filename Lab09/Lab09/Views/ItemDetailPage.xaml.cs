using Lab09.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab09.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}