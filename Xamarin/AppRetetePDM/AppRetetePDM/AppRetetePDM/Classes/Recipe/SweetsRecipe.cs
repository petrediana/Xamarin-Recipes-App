using AppRetetePDM.Classes.Ingredient;
using Newtonsoft.Json;
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

        public List<IBaseIngredient> BaseIngredients { get => _baseIngredients; set => _baseIngredients = value;}
        public string RecipeName { get => _recipeName; set => _recipeName = value; }
        public string RecipeDescriptions { get => _recipeDescription; set => _recipeDescription = value; }

        [JsonIgnore]
        public string Ingredients { get => GetBaseIngredients(); }
        public string GetBaseIngredients()
        {
            StringBuilder ingredientsBuilder = new StringBuilder();

            foreach (var baseIngredient in _baseIngredients)
            {
                ingredientsBuilder.Append(baseIngredient.ToString());
                ingredientsBuilder.Append("\n");
            }

            //ingredientsBuilder.Remove(ingredientsBuilder.Length - 2, 1);
            return ingredientsBuilder.ToString();
        }
    }
}
