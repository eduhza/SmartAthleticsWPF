﻿using SmartAthleticsWPF.ViewModels;
using SmartAthleticsWPF.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SmartAthleticsWPF.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "LiveGraph")
            {
                //this.viewModel.ChangeView(0);
                viewModel.SelectedViewModel = new LiveGraphViewModel(); //Era p ser LiveGraphViewModel, esta sendo iniciado no construtor do LiveGraphView.
            }
            if (parameter.ToString() == "Calibration")
            {
                //this.viewModel.ChangeView(1);
                viewModel.SelectedViewModel = new CalibrationViewModel();
            }
            if (parameter.ToString() == "Settings")
            {
                //this.viewModel.ChangeView(2);
                viewModel.SelectedViewModel = new SettingsViewModel();
            }
            if (parameter.ToString() == "Info")
            {
                //this.viewModel.ChangeView(3);
                viewModel.SelectedViewModel = new InfoViewModel();
            }
        }
    }
}
