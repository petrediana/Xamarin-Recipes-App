using AppRetetePDM.Classes.Recipe;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Services.JsonHelper
{
    public class JsonParserService : IJsonParserService
    {
        public IEnumerable<IBaseRecipe> DeserializeBaseRecipesFromString(string serialisedJsonArray)
        {
            return JsonConvert
               .DeserializeObject<IEnumerable<IBaseRecipe>>(serialisedJsonArray, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

        }

        public string SerializeBaseRecipesFromList(IEnumerable<IBaseRecipe> baseRecipes)
        {
            return JsonConvert
               .SerializeObject(baseRecipes, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

        }
    }
}
