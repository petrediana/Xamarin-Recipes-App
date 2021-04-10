using AppRetetePDM.ViewModels.BaseViewModels;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppRetetePDM.Classes.Recipe;
using AppRetetePDM.Classes.Ingredient;
using System.Linq;

namespace AppRetetePDM.ViewModels
{
    public class RecipeRandomRecommendationPageViewModel : BaseViewModel 
    {
        public RecipeRandomRecommendationPageViewModel()
        {
            Recipe = new ObservableCollection<IBaseRecipe>
            {
                _recommandationService.Recommandation
            };

            RefreshCommand = new AsyncCommand(Refresh);
            IsRefreshing = false;
        }


        public ObservableCollection<IBaseRecipe> Recipe { get; set; }
        public AsyncCommand RefreshCommand { get; }

        

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }

        private async Task Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(1000);

            Recipe.Clear();
            Recipe.Add(_recommandationService.Recommandation);

            IsRefreshing = false;
        }

    }
}
