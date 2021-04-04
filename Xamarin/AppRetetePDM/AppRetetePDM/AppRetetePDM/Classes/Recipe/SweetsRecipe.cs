using AppRetetePDM.Classes.Ingredient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

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
        private List<BaseIngredient> _baseIngredients = new List<BaseIngredient>();

        public void AddIngredient(BaseIngredient baseIngredient)
        {
            _baseIngredients.Add(baseIngredient);
        }

        public void AddMoreIngredients(IEnumerable<BaseIngredient> baseIngredients)
        {
            foreach (var baseIngredient in baseIngredients)
            {
                AddIngredient(baseIngredient);
            }
        }

        [JsonIgnore] [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Ignore]
        public List<BaseIngredient> BaseIngredients { get => _baseIngredients; set => _baseIngredients = value;}
        public string RecipeName { get => _recipeName; set => _recipeName = value; }
        public string RecipeDescriptions { get => _recipeDescription; set => _recipeDescription = value; }

        [JsonIgnore]
        public string Ingredients
        {
            get => _ingredients;

            set
            {
                _ingredients = value;
            }
        }

        [JsonIgnore]
        private string _ingredients = string.Empty;
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
