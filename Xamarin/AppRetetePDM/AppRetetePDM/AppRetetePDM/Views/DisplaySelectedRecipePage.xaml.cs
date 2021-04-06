using AppRetetePDM.Classes.Recipe;
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
    public partial class DisplaySelectedRecipePage : ContentPage
    {

        private DisplaySelectedRecipePageViewModel _model;

        public DisplaySelectedRecipePage(SweetsRecipe selected)
        {
            InitializeComponent();

            _model = new DisplaySelectedRecipePageViewModel(selected);

            BindingContext = _model;
        }

        private void ModifyRecipeBtn_Clicked(object sender, EventArgs e)
        {
            _model.UpdateCurrentRecipeProperties();
        }

        private async void DeleteRecipeBtn_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Warning!",
                "You are about to delete this recipe!!\nAre you really sure?",
                "Yes", "No");
            if (answer)
            {
                _model.DeleteCurrentRecipe();
            }
        }
    }
}