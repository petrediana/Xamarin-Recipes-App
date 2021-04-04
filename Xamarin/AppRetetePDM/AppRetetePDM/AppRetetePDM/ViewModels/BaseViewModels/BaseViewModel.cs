using AppRetetePDM.Services.DataBase;
using AppRetetePDM.Services.JsonHelper;
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
        }

        protected readonly IJsonParserService _jsonParserService;
        protected readonly DaoSweetRecipes _daoInstance;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string caller)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
