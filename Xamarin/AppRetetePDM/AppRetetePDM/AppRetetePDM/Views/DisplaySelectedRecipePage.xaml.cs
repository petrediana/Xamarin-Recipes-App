using AppRetetePDM.Classes.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRetetePDM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplaySelectedRecipePage : ContentPage
    {
        private SweetsRecipe _selected;

        public DisplaySelectedRecipePage(SweetsRecipe selected)
        {
            InitializeComponent();
            this._selected = selected;

            BindingContext = Recipe;
        }

        public SweetsRecipe Recipe { get => _selected; set => _selected = value; }
    }
}