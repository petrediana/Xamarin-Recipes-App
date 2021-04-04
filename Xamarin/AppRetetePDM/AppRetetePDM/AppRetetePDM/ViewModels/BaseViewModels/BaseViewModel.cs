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
        }

        protected readonly IJsonParserService _jsonParserService;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string caller)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
