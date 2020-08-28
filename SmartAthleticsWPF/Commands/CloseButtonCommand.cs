using SmartAthleticsWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SmartAthleticsWPF.Commands
{
    public class CloseButtonCommand : ICommand
    {
        public LiveGraphViewModel ViewModel { get; set; }
        public CloseButtonCommand(LiveGraphViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.CloseButton();
        }
    }
} 
