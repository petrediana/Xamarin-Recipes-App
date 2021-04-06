using AppRetetePDM.Classes.Recipe;
using AppRetetePDM.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppRetetePDM.ViewModels
{
    public class DisplaySelectedRecipePageViewModel : BaseViewModel
    {
        public DisplaySelectedRecipePageViewModel(SweetsRecipe selected)
        {
            Selected = selected;

            RecipeName = Selected.RecipeName;
            RecipeDescriptions = Selected.RecipeDescriptions;
            Ingredients = Selected.Ingredients;
        }

        private string _recipeDescriptions;
        private string _recipeName;
        private string _ingredients;
        public string RecipeName
        {
            get => _recipeName;
            set
            {
                if (_recipeName != value)
                {
                    _recipeName = value;
                    OnPropertyChanged("RecipeName");
                }
            }
        }
        public string RecipeDescriptions
        {
            get => _recipeDescriptions;
            set
            {
                if (_recipeDescriptions != value)
                {
                    _recipeDescriptions = value;
                    OnPropertyChanged("RecipeDescriptions");
                }
            }
        }
        public string Ingredients
        {
            get => _ingredients;
            set
            {
                if (_ingredients != value)
                {
                    _ingredients = value;
                    OnPropertyChanged("Ingredients");
                }
            }
        }

        public SweetsRecipe Selected { get; internal set; }

        public void UpdateCurrentRecipeProperties()
        {
            if (CheckIfEntryFieldsAreValid())
            {
                Selected.RecipeName = RecipeName;
                Selected.RecipeDescriptions = RecipeDescriptions;
                Selected.Ingredients = Ingredients;

                _daoInstance.UpdateRecipe(Selected);

                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        public void DeleteCurrentRecipe()
        {
            _daoInstance.DeleteRecipe(Selected);
            Application.Current.MainPage.Navigation.PopAsync();
        }

        private bool CheckIfEntryFieldsAreValid()
        {
            return (!string.IsNullOrEmpty(RecipeName) && !string.IsNullOrEmpty(RecipeDescriptions) && !string.IsNullOrEmpty(Ingredients));
        }
    }
}
