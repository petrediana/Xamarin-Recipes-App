using AppRetetePDM.Classes.Ingredient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Classes.Recipe
{
    public interface IBaseRecipe
    {
        public string GetBaseIngredients(IEnumerable<IBaseIngredient> baseIngredients);
        string RecipeName { get; set; }
        string RecipeDescriptions { get; set; }

    }
}
