using AppRetetePDM.Classes.Ingredient;
using AppRetetePDM.Classes.Recipe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppRetetePDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private List<IBaseRecipe> _baseRecipes = new List<IBaseRecipe>();
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CreateSomeRecipes();


            listViewRecipesMainPage.ItemsSource = _baseRecipes;
            BindingContext = _baseRecipes[0];
        }

        private void CreateSomeRecipes()
        {
            IBaseRecipe recipe1 = new SweetsRecipe
            {
                RecipeName = "Placinta cu mere",
                RecipeDescriptions = "O placinta buna"
            };

            IBaseIngredient ingredient1 = new BaseIngredient
            {
                Name = "Mere",
                Quantity = "20"
            };

            IBaseIngredient ingredient2 = new BaseIngredient
            {
                Name = "Faina",
                Quantity = "4 pahare"
            };

            IBaseIngredient ingredient3 = new BaseIngredient
            {
                Name = "Drojdie",
                Quantity = "o bucata"
            };

            List<IBaseIngredient> baseIngredients1 =
                new List<IBaseIngredient>() { ingredient1, ingredient2, ingredient3 };

            recipe1.AddMoreIngredients(baseIngredients1);

            _baseRecipes.Add(recipe1);
            _baseRecipes.Add(recipe1);
            _baseRecipes.Add(recipe1);
        }
    }
}
