using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Databinding_E_game
{
    public class Game : INotifyPropertyChanged
    {
        private double rating;
        private string console;

        public string Title { get; set; }
        public string Description { get; set; }
        public string Editor { get; set; }
        public int Year { get; set; }

        public string Console
        {
            get => console;
            set { 
                console = value;
                OnPropertyChanged();
            }
        }
        public string Info => $"{Title} : {Description}";

        public double Rating
        {
            get => rating;
            set
            {
                rating = value;
                OnPropertyChanged();
            }
        }
        public string CoverPath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
