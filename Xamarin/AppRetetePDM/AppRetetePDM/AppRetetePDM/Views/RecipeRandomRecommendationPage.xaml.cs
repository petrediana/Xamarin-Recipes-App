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
    public partial class RecipeRandomRecommendationPage : ContentPage
    {
        RecipeRandomRecommendationPageViewModel _model;
        public RecipeRandomRecommendationPage()
        {
            InitializeComponent();
            _model = new RecipeRandomRecommendationPageViewModel();

            BindingContext = _model;
        }
    }
}