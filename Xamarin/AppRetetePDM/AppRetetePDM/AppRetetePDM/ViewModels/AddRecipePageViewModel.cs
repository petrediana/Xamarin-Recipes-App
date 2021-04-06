using AppRetetePDM.Classes.Recipe;
using AppRetetePDM.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppRetetePDM.ViewModels
{
    public class AddRecipePageViewModel : BaseViewModel
    {
        public AddRecipePageViewModel()
        {

        }


        public string RecipeName { get; set; }
        public string RecipeDescriptions { get; set; }
        public string Ingredients { get; set; }

        public bool AddRecipeCommand()
        {
            if (CheckEntryFields())
            {
                SweetsRecipe recipe = new SweetsRecipe
                {
                    RecipeName = RecipeName,
                    RecipeDescriptions = RecipeDescriptions,
                    Ingredients = Ingredients
                };

                _daoInstance.AddRecipe(recipe);
                Application.Current.MainPage.Navigation.PopAsync();
                return true;
            }

            return false;
        }

        private bool CheckEntryFields()
        {
            return (!string.IsNullOrEmpty(RecipeName) && !string.IsNullOrEmpty(RecipeDescriptions) && !string.IsNullOrEmpty(Ingredients));
        }
    }
}
