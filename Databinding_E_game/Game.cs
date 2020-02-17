using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Databinding_E_game
{
    public class Game : INotifyPropertyChanged
    {
        private double rating;
        private string console;
        private string title;
        private string description;
        private string editor;
        private int year;
        private string coverPath;

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }

        public string Editor
        {
            get => editor;
            set
            {
                editor = value;
                OnPropertyChanged();
            }
        }

        public int Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged();
            }
        }

        public string Console
        {
            get => console;
            set
            {
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
        public string CoverPath { 
            get => coverPath;
            set { 
                coverPath = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
