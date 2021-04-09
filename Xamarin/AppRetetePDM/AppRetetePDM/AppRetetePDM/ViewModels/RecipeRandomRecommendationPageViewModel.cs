using AppRetetePDM.ViewModels.BaseViewModels;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppRetetePDM.Classes.Recipe;
using AppRetetePDM.Classes.Ingredient;
using System.Linq;

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

            _recipesForRandom = new List<IBaseRecipe>
            {
                Recipe1(),
                Recipe2(),
                Recipe3(),
                Recipe4(),
                Recipe5()
            };
        }


        public ObservableCollection<IBaseRecipe> Recipe { get; set; }
        public AsyncCommand RefreshCommand { get; }

        private List<IBaseRecipe> _recipesForRandom;

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
            await Task.Delay(1000);

            Recipe.Clear();
            Recipe.Add(GetRandomRecipe());

            IsRefreshing = false;
        }

        private IBaseRecipe GetRandomRecipe()
        {
            Random random = new Random();
            var randomResult = random.Next(_recipesForRandom.Count);

            return _recipesForRandom[randomResult];
        }

        private IBaseRecipe Recipe5()
        {
            IBaseRecipe recipe1 = new SweetsRecipe
            {
                RecipeName = "Salata de fructe",
                RecipeDescriptions = "whatever..."
            };

            BaseIngredient ingredient1 = new BaseIngredient
            {
                Name = "Mere",
                Quantity = "10 felii"
            };

            BaseIngredient ingredient2 = new BaseIngredient
            {
                Name = "Banana",
                Quantity = "5 felii"
            };

            BaseIngredient ingredient3 = new BaseIngredient
            {
                Name = "Cirese",
                Quantity = "20 de jumatati"
            };

            BaseIngredient ingredient4 = new BaseIngredient
            {
                Name = "Piersica",
                Quantity = "5 felii"
            };

            BaseIngredient ingredient5 = new BaseIngredient
            {
                Name = "Prune",
                Quantity = "4 jumatati"
            };


            List<BaseIngredient> baseIngredients1 =
                new List<BaseIngredient>() { ingredient1, ingredient2, ingredient3, ingredient4, ingredient5 };

            recipe1.AddMoreIngredients(baseIngredients1);

            SweetsRecipe theRecipe = (SweetsRecipe)recipe1;
            theRecipe.ID = 5;
            theRecipe.Ingredients = theRecipe.GetBaseIngredients();

            return theRecipe;
        }
        private IBaseRecipe Recipe4()
        {
            IBaseRecipe recipe1 = new SweetsRecipe
            {
                RecipeName = "Paine cu ou si zahar",
                RecipeDescriptions = "Un tortulet simplu"
            };

            BaseIngredient ingredient1 = new BaseIngredient
            {
                Name = "Paine neagra",
                Quantity = "2 felii"
            };

            BaseIngredient ingredient2 = new BaseIngredient
            {
                Name = "Oua",
                Quantity = "2 batute"
            };

            BaseIngredient ingredient3 = new BaseIngredient
            {
                Name = "Lapte",
                Quantity = "o lingurita"
            };

            BaseIngredient ingredient4 = new BaseIngredient
            {
                Name = "Zahar pudra",
                Quantity = "dupa preferinta"
            };


            List<BaseIngredient> baseIngredients1 =
                new List<BaseIngredient>() { ingredient1, ingredient2, ingredient3, ingredient4 };

            recipe1.AddMoreIngredients(baseIngredients1);

            SweetsRecipe theRecipe = (SweetsRecipe)recipe1;
            theRecipe.ID = 4;
            theRecipe.Ingredients = theRecipe.GetBaseIngredients();

            return theRecipe;
        }
        private IBaseRecipe Recipe3()
        {
            IBaseRecipe recipe1 = new SweetsRecipe
            {
                RecipeName = "Tort de ciocolata",
                RecipeDescriptions = "Un tortulet simplu"
            };

            BaseIngredient ingredient1 = new BaseIngredient
            {
                Name = "Pudra de cacao",
                Quantity = "3 linguri"
            };

            BaseIngredient ingredient2 = new BaseIngredient
            {
                Name = "Faina",
                Quantity = "3 pahare"
            };

            BaseIngredient ingredient3 = new BaseIngredient
            {
                Name = "Lapte",
                Quantity = "un sfert de pahar"
            };

            BaseIngredient ingredient4 = new BaseIngredient
            {
                Name = "Esenta de vanilie",
                Quantity = "o lingurita"
            };

            BaseIngredient ingredient5 = new BaseIngredient
            {
                Name = "Apa minerala",
                Quantity = "jumatate de pahar"
            };


            List<BaseIngredient> baseIngredients1 =
                new List<BaseIngredient>() { ingredient1, ingredient2, ingredient3, ingredient4, ingredient5 };

            recipe1.AddMoreIngredients(baseIngredients1);

            SweetsRecipe theRecipe = (SweetsRecipe)recipe1;
            theRecipe.ID = 3;
            theRecipe.Ingredients = theRecipe.GetBaseIngredients();

            return theRecipe;
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

            SweetsRecipe theRecipe = (SweetsRecipe)recipe1;
            theRecipe.ID = 2;
            theRecipe.Ingredients = theRecipe.GetBaseIngredients();

            return theRecipe;
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

            SweetsRecipe theRecipe = (SweetsRecipe)recipe1;
            theRecipe.ID = 1;
            theRecipe.Ingredients = theRecipe.GetBaseIngredients();

            return recipe1;
        }
    }
}
