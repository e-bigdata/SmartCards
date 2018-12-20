﻿using Kadastr.WinClient.ViewModel;
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

namespace Kadastr.WinClient.View
{
    /// <summary>
    /// Interaction logic for MockInfoView.xaml
    /// </summary>
    public partial class MockInfoView : UserControl
    {
        private MainViewModel _model;

        public MockInfoView()
        {
            InitializeComponent();

            _model = new MainViewModel();

            DataContext = _model;
        }
    }
}
