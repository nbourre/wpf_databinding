using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Databinding_D_notification

{
    public class Employee : INotifyPropertyChanged
    {
        private int age;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
