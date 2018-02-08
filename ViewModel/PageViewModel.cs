using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace jhone_mvvmLigth.ViewModel
{
    public class PageViewModel
    {
        private INavigationService _navigationService;

        ICommand GoBackCommand { get; set; }

        PageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new RelayCommand(() => { _navigationService.GoBack(); });
        }
    }
}
