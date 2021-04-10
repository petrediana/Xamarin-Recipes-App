using AppRetetePDM.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Linq;
using MvvmHelpers.Commands;
using AppRetetePDM.Classes.ScheduledRecipe;

namespace AppRetetePDM.ViewModels
{
    class ScheduledRecipePageViewModel : BaseViewModel
    {
        public ScheduledRecipePageViewModel()
        {
            _recipeNames = _daoInstance
                            .GetAllSweetRecipes()
                            .Select(recipe => recipe.RecipeName)
                            .ToList();

            SelectedRecipeName = _recipeNames[0];
            SelectedDate = DateTime.Now;

            ScheduleRecipeCommand = new Command(ScheduleRecipeCommand_Click);

            try
            {
                var mostRecentScheduledRecipe = _daoscheduledRecipe.GetAllScheduledRecipes()[0];
                RecipeName = mostRecentScheduledRecipe.RecipeName;
                Date = mostRecentScheduledRecipe.Date;
            } catch (Exception ex) { }
            
        }

        private string _recipeName;
        private string _date;
        private List<string> _recipeNames;
        private string _selectedRecipeName;

        public List<string> RecipeNames { get => _recipeNames; }
        public ICommand ScheduleRecipeCommand { get; private set; }
        public string RecipeName
        {
            get => _recipeName;
            set
            {
                _recipeName = value;
                OnPropertyChanged("RecipeName");
            }
        }
        public string Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        public string SelectedRecipeName
        {
            get => _selectedRecipeName;
            set
            {
                _selectedRecipeName = value;
                OnPropertyChanged("SelectedRecipeName");
            }
        }

        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                _selectedDate = value;
                OnPropertyChanged("SelectedDate");
            }
        }

        private void ScheduleRecipeCommand_Click()
        {
            RecipeName = SelectedRecipeName;
            Date = SelectedDate.ToString("dd-mm-yyyy");

            ScheduledRecipe scheduledRecipe = new ScheduledRecipe
            {
                RecipeName = RecipeName,
                Date = Date
            };

            _daoscheduledRecipe.AddRecipe(scheduledRecipe);
        }
    }
}
