using SmartAthleticsWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SmartAthleticsWPF.Commands
{
    public class RecordButtonCommand : ICommand
    {
        public LiveGraphViewModel ViewModel { get; set; }
        public RecordButtonCommand(LiveGraphViewModel viewModel)
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
            this.ViewModel.RecordButton();
        }
    }
} 
