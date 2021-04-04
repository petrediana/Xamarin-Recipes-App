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

        private DisplaySelectedRecipePageViewModel _model = new DisplaySelectedRecipePageViewModel();

        public DisplaySelectedRecipePage(SweetsRecipe selected)
        {
            InitializeComponent();

            _model.RecipeName = selected.RecipeName;
            _model.RecipeDescriptions = selected.RecipeDescriptions;
            BindingContext = _model;
        }

    }
}