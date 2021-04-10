using AppRetetePDM.Classes.Recipe;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Services.Recommandations
{
    public interface IRecommandationService
    {
        IBaseRecipe Recommandation { get; }
    }
}
