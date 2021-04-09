using AppRetetePDM.Classes.Ingredient;
using AppRetetePDM.Classes.Recipe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using AppRetetePDM.Services.Logger;
using AppRetetePDM.Services.Http;
using AppRetetePDM.Services.JsonHelper;
using AppRetetePDM.ViewModels;
using AppRetetePDM.Views;

namespace AppRetetePDM
{
    public partial class MainPage : ContentPage
    {
        readonly MainPageViewModel _mainPageViewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = _mainPageViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            _mainPageViewModel.BaseRecipesCollection = await _mainPageViewModel.PrepareDataForList();
            /*_mainPageViewModel.BaseRecipesCollection.Add(Recipe2());
            _mainPageViewModel.BaseRecipesCollection.Add(Recipe2());
            _mainPageViewModel.BaseRecipesCollection.Add(Recipe2());
            _mainPageViewModel.BaseRecipesCollection.Add(Recipe2());
            _mainPageViewModel.BaseRecipesCollection.Add(Recipe2());
            _mainPageViewModel.BaseRecipesCollection.Add(Recipe2());*/
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            SweetsRecipe selected = (SweetsRecipe)_mainPageViewModel.SelectedBaseRecipe;
            if (selected != null)
            {
                await Navigation.PushAsync(new DisplaySelectedRecipePage(selected));
            }            
        }

        private async void AddRecipeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipePage());
        }

        private async void AboutToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutAppPage());
        }

        private async void RandomRecommendation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeRandomRecommendationPage());
        }

        private IBaseRecipe Recipe2()
        {
            IBaseRecipe recipe1 = new SweetsRecipe
            {
                RecipeName = "Calitate cu dulceata",
                RecipeDescriptions = "Cand ai chef de clatite..."
            };

            BaseIngredient ingredient1 = new BaseIngredient
            {
                Name = "Dulceata de visine",
                Quantity = "un borcan"
            };

            BaseIngredient ingredient2 = new BaseIngredient
            {
                Name = "Faina",
                Quantity = "un pahar"
            };

            BaseIngredient ingredient3 = new BaseIngredient
            {
                Name = "Apa minerala",
                Quantity = "un sfert de pahar"
            };

            List<BaseIngredient> baseIngredients1 =
                new List<BaseIngredient>() { ingredient1, ingredient2, ingredient3 };

            recipe1.AddMoreIngredients(baseIngredients1);

            return recipe1;
        }

        private IBaseRecipe Recipe1()
        {
            IBaseRecipe recipe1 = new SweetsRecipe
            {
                RecipeName = "Placinta cu mere",
                RecipeDescriptions = "O placinta buna"
            };

            BaseIngredient ingredient1 = new BaseIngredient
            {
                Name = "Mere",
                Quantity = "20"
            };

            BaseIngredient ingredient2 = new BaseIngredient
            {
                Name = "Faina",
                Quantity = "4 pahare"
            };

            BaseIngredient ingredient3 = new BaseIngredient
            {
                Name = "Drojdie",
                Quantity = "o bucata"
            };

            List<BaseIngredient> baseIngredients1 =
                new List<BaseIngredient>() { ingredient1, ingredient2, ingredient3 };

            recipe1.AddMoreIngredients(baseIngredients1);

            return recipe1;
        }
    }
}
