using AppRetetePDM.Classes.Recipe;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Services.JsonHelper
{
    public interface IJsonParserService
    {
        string SerializeBaseRecipesFromList(IEnumerable<IBaseRecipe> baseRecipes);
        IEnumerable<IBaseRecipe> DeserializeBaseRecipesFromString(string serialisedJsonArray);

    }
}
