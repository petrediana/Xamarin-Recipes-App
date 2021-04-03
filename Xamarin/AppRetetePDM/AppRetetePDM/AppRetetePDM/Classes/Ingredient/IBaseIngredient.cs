using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Classes.Ingredient
{
    public interface IBaseIngredient
    {
        string Name { get; set; }
        string Quantity { get; set; }
    }
}
