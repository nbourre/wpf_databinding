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
    public partial class MainWindow : Window
    {
        private Game currentGame;

        public ObservableCollection<Game> Games { get; set; }

        public Game CurrentGame { get; set; }

        public int MaxIndex { get; set; }

        public MainWindow()
        {
            Games = new ObservableCollection<Game>();

            InitializeComponent();


            Games.Add(
                new Game { Title = "Super Mario Bros.",
                    Console = "Switch", CoverPath = "images/super_mario.png",
                    Description = "Plumber who's never tired of saving the Princess.",
                    Editor = "Nintendo", Rating = 10, Year = 1985 });
            Games.Add(
                new Game { Title = "Ark",
                    Console = "XBox", CoverPath = "images/ark.jpg",
                    Description = "Survive in a dinosaur world",
                    Editor = "I don't remember", Rating = 7, Year = 2014 });

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


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CurrentGame.Rating = e.NewValue;
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine((int)e.NewValue);

            int newIndex = (int)e.NewValue;

            CurrentGame = Games[newIndex];

        }
    }
}
