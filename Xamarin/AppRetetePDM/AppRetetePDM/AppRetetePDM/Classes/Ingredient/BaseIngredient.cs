using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetetePDM.Classes.Ingredient
{
    public class BaseIngredient : IBaseIngredient
    {
        public BaseIngredient()
        {
            _ingriedentName = string.Empty;
            _quantity = string.Empty;
        }

        private string _ingriedentName;
        private string _quantity;

        public string Name { get => _ingriedentName; set => _ingriedentName = value; }
        public string Quantity { get => _quantity; set => _quantity = value; }

        public override string ToString()
        {
            return $"{_ingriedentName} -> {_quantity}";
        }
    }
}
