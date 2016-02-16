﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
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
using Autofac;
using Autofac.Integration.Mef;
using Trakkr.Model;
using Trakkr.ViewModels;

namespace Trakkr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel;

        public IEventRepository Repository { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            mainViewModel = (MainViewModel)Application.Current.Resources["MainViewModel"];

            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var builder = new ContainerBuilder();
            builder.RegisterComposablePartCatalog(catalog);
            var container = builder.Build();

            Repository = container.Resolve<IEventRepository>();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = new EventViewModel();
            mainViewModel.Events.Add(viewModel);
        }
    }
}
