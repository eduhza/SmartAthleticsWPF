using SmartAthleticsWPF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace SmartAthleticsWPF.ViewModels
{
    /*  Control the navigation of the views */
    public class MainViewModel : BaseViewModel
    {

        private BaseViewModel _selectedViewModel;// = new LiveGraphViewModel(); //STARTS AT LIVEGRAPH VIEW

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { SetProperty(ref _selectedViewModel, value); }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            SelectedViewModel = new BaseViewModel();
            //SelectedViewModel = new LiveGraphViewModel();
            //RegisterViews();
        }

        //internal void ChangeView(int i)
        //{
        //    SelectedViewModel = baseViewModels[i];
        //}


        //BaseViewModel[] baseViewModels = new BaseViewModel[4];
        //private void RegisterViews()
        //{
        //    baseViewModels[0] = new LiveGraphViewModel();
        //    baseViewModels[1] = new CalibrationViewModel();
        //    baseViewModels[2] = new SettingsViewModel();
        //    baseViewModels[3] = new InfoViewModel();
        //    SelectedViewModel = baseViewModels[0];
        //}

    }
}
