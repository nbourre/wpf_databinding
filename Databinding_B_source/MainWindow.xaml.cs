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

namespace Databinding_B_source
{
    /// <summary>
    /// Code-behind de ma fenêtre principale
    /// </summary>
    public partial class MainWindow : Window
    {
        public Employee employee { get; set; }

        public MainWindow()
        {
            employee = new Employee()
            {
                Age = 45,
                LastName = "Seemann",
                Name = "Mark",
                PicturePath = "images/Seemann.jpeg"
            };

            InitializeComponent();

            Binding pictureBinding = new Binding();
            pictureBinding.Source = employee;
            pictureBinding.Path = new PropertyPath("PicturePath");

            EmployeePicture.SetBinding(Image.SourceProperty, pictureBinding);
        }
    }
}
