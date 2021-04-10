using AppRetetePDM.Services.DataBase;
using AppRetetePDM.Services.JsonHelper;
using AppRetetePDM.Services.Recommandations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppRetetePDM.ViewModels.BaseViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            _jsonParserService = new JsonParserService();
            _daoInstance = DaoSweetRecipes.Instance;
            _recommandationService = new RecommandationService();

        }

        protected readonly IJsonParserService _jsonParserService;
        protected readonly DaoSweetRecipes _daoInstance;
        protected readonly IRecommandationService _recommandationService;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string caller)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
