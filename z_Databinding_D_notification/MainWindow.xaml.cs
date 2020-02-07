using System.Windows;

namespace Databinding_D_notification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Employee Employee { get; set; }

        public MainWindow()
        {
            Employee = new Employee()
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
            Employee.Age = 40;
        }
    }
}
