using AppRetetePDM.Classes.Ingredient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Classes.Recipe
{
    public interface IBaseRecipe
    {
        string GetBaseIngredients(IEnumerable<IBaseIngredient> baseIngredients);
        void AddIngredient(IBaseIngredient baseIngredient);
        void AddMoreIngredients(IEnumerable<IBaseIngredient> baseIngredients);
        string RecipeName { get; set; }
        string RecipeDescriptions { get; set; }

    }
}
