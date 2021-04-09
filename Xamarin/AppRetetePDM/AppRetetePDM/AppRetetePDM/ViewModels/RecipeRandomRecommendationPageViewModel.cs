using AppRetetePDM.ViewModels.BaseViewModels;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppRetetePDM.Classes.Recipe;
using AppRetetePDM.Classes.Ingredient;

namespace AppRetetePDM.ViewModels
{
    public class RecipeRandomRecommendationPageViewModel : BaseViewModel 
    {
        public RecipeRandomRecommendationPageViewModel()
        {
            Recipe = new ObservableCollection<IBaseRecipe>
            {
                Recipe1()
            };

            RefreshCommand = new AsyncCommand(Refresh);
            IsRefreshing = false;
        }


        public ObservableCollection<IBaseRecipe> Recipe { get; set; }
        public AsyncCommand RefreshCommand { get; }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }

        private async Task Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(1500);

            Recipe.Clear();
            Recipe.Add(Recipe2());

            IsRefreshing = false;
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
