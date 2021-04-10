using AppRetetePDM.Classes.Ingredient;
using AppRetetePDM.Classes.Recipe;
using AppRetetePDM.Services.Http;
using AppRetetePDM.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRetetePDM.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
        }

        public async Task<ObservableCollection<IBaseRecipe>> PrepareDataForList()
        {
            ObservableCollection<IBaseRecipe> collection = new ObservableCollection<IBaseRecipe>();
            
            var dataFromDb = _daoInstance.GetAllSweetRecipes();
            if (dataFromDb.Count != 0)
            {
                foreach (var recipe in dataFromDb)
                {
                    collection.Add(recipe);
                }
            }
            else
            {
                var getJsonData = await HttpService.AsyncGetRequest();
                var parsedRecipeListFromJson = _jsonParserService.DeserializeBaseRecipesFromString(getJsonData);

                var finalValues = parsedRecipeListFromJson.Select(recipe => (SweetsRecipe)recipe).ToList();
                finalValues.ForEach(sweet => sweet.Ingredients = sweet.GetBaseIngredients());
                _daoInstance.AddListOfRecipes(finalValues);

                foreach (var recipe in finalValues)
                {
                    collection.Add(recipe);
                }
            }

            return collection;
        }

        private IBaseRecipe _selectedBaseRecipe = null;

        private ObservableCollection<IBaseRecipe> _baseRecipes = new ObservableCollection<IBaseRecipe>();
        public ObservableCollection<IBaseRecipe> BaseRecipesCollection
        {
            get => _baseRecipes;
            set
            {
                _baseRecipes = value;
                OnPropertyChanged("BaseRecipesCollection");
            }
        }
        public IBaseRecipe SelectedBaseRecipe
        {
            get => _selectedBaseRecipe;
            set
            {
                if (_selectedBaseRecipe != value)
                {
                    _selectedBaseRecipe = value;
                    OnPropertyChanged("SelectedBaseRecipe");
                }
            }
        }

        public void AddRecipeToCollection(IBaseRecipe recipe)
        {
            BaseRecipesCollection.Add(recipe);
        }
    }
}
