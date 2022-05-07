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
using Telecom_Neva_Svyaz.classes;
using Telecom_Neva_Svyaz.Pages;

namespace Telecom_Neva_Svyaz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page_subscribers());
            Manager.MainFrame = MainFrame;
        }

     
        private void B_Sub_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_subscribers());
        }

        private void B_management_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_equipment_management());
        }

        private void B_assets_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Assets());
        }

        private void B_Billing_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Billing());
        }

        private void B_support_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Users_support());
        }

        private void B_CRM_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_CRM());
        }
    }
}
