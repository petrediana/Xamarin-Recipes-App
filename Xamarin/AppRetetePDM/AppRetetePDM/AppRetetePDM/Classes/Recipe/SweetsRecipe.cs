using AppRetetePDM.Classes.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppRetetePDM.Classes.Recipe
{
    public class SweetsRecipe : IBaseRecipe
    {
        public SweetsRecipe()
        {
            _recipeName = string.Empty;
            _recipeDescription = string.Empty;
        }

        private string _recipeName;
        private string _recipeDescription;
        private List<IBaseIngredient> _baseIngredients = new List<IBaseIngredient>();

        public void AddIngredient(IBaseIngredient baseIngredient)
        {
            _baseIngredients.Add(baseIngredient);
        }

        public void AddMoreIngredients(IEnumerable<IBaseIngredient> baseIngredients)
        {
            foreach (var baseIngredient in baseIngredients)
            {
                AddIngredient(baseIngredient);
            }
        }

        public string Ingredients { get => GetBaseIngredients(_baseIngredients); }
        public string RecipeName { get => _recipeName; set => _recipeName = value; }
        public string RecipeDescriptions { get => _recipeDescription; set => _recipeDescription = value; }

        public string GetBaseIngredients(IEnumerable<IBaseIngredient> baseIngredients)
        {
            StringBuilder ingredientsBuilder = new StringBuilder();

            foreach (var baseIngredient in baseIngredients)
            {
                ingredientsBuilder.Append(baseIngredient.ToString());
                ingredientsBuilder.Append("\n");
            }

            ingredientsBuilder.Remove(ingredientsBuilder.Length - 2, 1);
            return ingredientsBuilder.ToString();
        }
    }
}
