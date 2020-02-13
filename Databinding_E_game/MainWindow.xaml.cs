using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Databinding_E_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Game currentGame;

        public ObservableCollection<Game> games { get; set; }

        public Game CurrentGame {
            get => currentGame;
            set
            {
                currentGame = value;
                OnPropertyChanged();
            }
        }

        public int MaxIndex { get; set; }

        public MainWindow()
        {
            games = new ObservableCollection<Game>()
            {
                new Game {Title = "Super Mario Bros.",
                    Console="Switch", CoverPath="images/super_mario.png",
                    Description="Plumber who's never tired of saving the Princess.",
                    Editor="Nintendo", Rating=10, Year=1985},

                new Game {Title = "Ark",
                    Console="XBox", CoverPath="images/ark.jpg",
                    Description="Survive in a dinosaur world",
                    Editor="I don't remember", Rating=7, Year=2014},

                new Game {Title = "Balloon Fight",
                    Console="PS4", CoverPath="images/balloon_fight.jpg",
                    Description="Ballon nerds fighting",
                    Editor="Something nintendo", Rating=8, Year=1988},

            };

            CurrentGame = games[0];
            MaxIndex = games.Count - 1;

            InitializeComponent();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CurrentGame.Rating = e.NewValue;
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine((int)e.NewValue);

            int newIndex = (int)e.NewValue;

            CurrentGame = games[newIndex];

        }
    }
}
