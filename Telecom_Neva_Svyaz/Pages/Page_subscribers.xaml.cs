﻿using System;
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

namespace Telecom_Neva_Svyaz.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_subscribers.xaml
    /// </summary>
    public partial class Page_subscribers : Page
    {
        public Page_subscribers()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Telecom_Neva_SvyazEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DG_Subscriber.ItemsSource = Telecom_Neva_SvyazEntities.GetContext().Subscriber.ToList();
        }
    }
}
