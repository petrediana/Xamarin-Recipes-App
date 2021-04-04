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
        public DisplaySelectedRecipePageViewModel()
        {
            ModifyRecipeCommand = new Command(UpdateCurrentRecipeProperties);

        }

        private string _recipeDescriptions;
        private string _recipeName;
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
        public ICommand ModifyRecipeCommand { get; set; }

        private void UpdateCurrentRecipeProperties()
        {
            if (!string.IsNullOrEmpty(RecipeName))
            {
                RecipeName = "dsfijdasdfas";
            }
        }


    }
}
