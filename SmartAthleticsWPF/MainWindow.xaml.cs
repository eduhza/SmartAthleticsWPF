using SmartAthleticsWPF.ViewModels;
using SmartAthleticsWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace SmartAthleticsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk2Mzg0QDMxMzgyZTMyMmUzMFJlNDVuaUtIMkN1UFFrNDRxcGFOaDZCRUtDV0dhQ1YvQkEvVTg2K0gvUGs9;Mjk2Mzg1QDMxMzgyZTMyMmUzMG5aSkhqcWxPYWdqcWNhRmhtbGJMeEtWWE9VbTdxRUNkZldydWM1Wk1aV2M9");
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Nav_pnl_MouseLeave(object sender, MouseEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void ToolTip_MouseEnter(object sender, MouseEventArgs e)
        {
            if (nav_pnl.Width == 65)
            {
                tt_LiveGraph.Visibility = Visibility.Visible;
                tt_Calibration.Visibility = Visibility.Visible;
                tt_Settings.Visibility = Visibility.Visible;
                tt_Info.Visibility = Visibility.Visible;
            }
            if (nav_pnl.Width == 230)
            {
                tt_LiveGraph.Visibility = Visibility.Collapsed;
                tt_Calibration.Visibility = Visibility.Collapsed;
                tt_Settings.Visibility = Visibility.Collapsed;
                tt_Info.Visibility = Visibility.Collapsed;
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

    }

}
