﻿using cinemApp.ViewModel;
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

namespace cinemApp.View
{
    /// <summary>
    /// Логика взаимодействия для SignUc.xaml
    /// </summary>
    public partial class SignUc : UserControl
    {
        public SignUc()
        {
            InitializeComponent();
            this.DataContext = new SignUcModel()
            {
                sign = this
            };
         
        }

      

    }
}