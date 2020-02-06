using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBinding_C_DataContext

{
    public class Employee : INotifyPropertyChanged
    {
        private int age;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }
        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
