using AppRetetePDM.Classes.Ingredient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Classes.Recipe
{
    public interface IBaseRecipe
    {
        string GetBaseIngredients();
        void AddIngredient(BaseIngredient baseIngredient);
        void AddMoreIngredients(IEnumerable<BaseIngredient> baseIngredients);
        string RecipeName { get; set; }
        string RecipeDescriptions { get; set; }

    }
}
