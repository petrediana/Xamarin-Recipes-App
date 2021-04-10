using AppRetetePDM.ViewModels;
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
    public partial class ScheduledRecipePage : ContentPage
    {
        ScheduledRecipePageViewModel _model;
        public ScheduledRecipePage()
        {
            InitializeComponent();

            _model = new ScheduledRecipePageViewModel();
            BindingContext = _model;
        }
    }
}