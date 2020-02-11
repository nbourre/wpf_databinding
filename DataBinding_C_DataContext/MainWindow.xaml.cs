﻿using System.Windows;

namespace DataBinding_C_DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employee.Age = 40;
        }
    }
}
