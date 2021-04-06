using AppRetetePDM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRetetePDM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddRecipePage : ContentPage
    {
        private AddRecipePageViewModel _model;
        public AddRecipePage()
        {
            InitializeComponent();
            _model = new AddRecipePageViewModel();

            BindingContext = _model;
        }

        private async void AddRecipeBtn_Clicked(object sender, EventArgs e)
        {
            if (!_model.AddRecipeCommand())
            {
                await DisplayAlert("Invalid action",
                    "Please insert a valid recipe!\nName, Description and Ingredients can't be empty!",
                    "OK");
            }
        }
    }
}