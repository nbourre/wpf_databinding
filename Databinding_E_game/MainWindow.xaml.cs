using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Databinding_E_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Game currentGame;
        private ObservableCollection<Game> games = new ObservableCollection<Game>();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Game> Games { get => games; set => games = value; }

        public Game CurrentGame { 
            get => currentGame; 
            set {
                currentGame = value;
                OnPropertyChanged();
            }
        }

        public int MaxIndex { get; set; }

        public MainWindow()
        {
            InitializeComponent();


            Games.Add(
                new Game
                {
                    Title = "Super Mario Bros.",
                    Console = "Switch",
                    CoverPath = "images/super_mario.png",
                    Description = "Plumber who's never tired of saving the Princess.",
                    Editor = "Nintendo",
                    Rating = 10,
                    Year = 1985
                });
            Games.Add(
                new Game
                {
                    Title = "Ark",
                    Console = "XBox",
                    CoverPath = "images/ark.jpg",
                    Description = "Survive in a dinosaur world",
                    Editor = "I don't remember",
                    Rating = 7,
                    Year = 2014
                });

            Games.Add(
                new Game
                {
                    Title = "Balloon Fight",
                    Console = "PS4",
                    CoverPath = "images/balloon_fight.jpg",
                    Description = "Ballon nerds fighting",
                    Editor = "Something nintendo",
                    Rating = 8,
                    Year = 1988
                });

            CurrentGame = Games[0];
            MaxIndex = Games.Count - 1;

        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CurrentGame.Rating = e.NewValue;
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)e.Source;
            CurrentGame = (Game)lv.SelectedItem;
        }
    }
}
