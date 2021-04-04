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

    }
}