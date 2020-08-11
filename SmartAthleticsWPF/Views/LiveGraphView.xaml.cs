using SmartAthleticsWPF.Models;
using SmartAthleticsWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using SmartAthleticsWPF.Commands;

namespace SmartAthleticsWPF.Views
{
    /// <summary>
    /// Interaction logic for LiveGraphView.xaml
    /// </summary>
    public partial class LiveGraphView : UserControl 
    {
        private LiveGraphViewModel _vm;
        public LiveGraphView()
        {
            InitializeComponent();

            this._vm = new LiveGraphViewModel();
            this.DataContext = this._vm;

            this._vm.LiveGraphSuspendNotifiCation = new Action(LiveGraphChart.SuspendSeriesNotification);
            this._vm.LiveGraphResumeNotification = new Action(LiveGraphChart.ResumeSeriesNotification);
            this._vm.COPSuspendNotifiCation = new Action(CopChart.SuspendSeriesNotification);
            this._vm.COPResumeNotification = new Action(CopChart.ResumeSeriesNotification);
        }

    }
}
