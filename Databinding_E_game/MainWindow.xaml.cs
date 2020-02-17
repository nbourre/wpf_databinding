using Microsoft.Win32;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game>();
        public ObservableCollection<string> Consoles { get; set; } = new ObservableCollection<string>();

        public Game CurrentGame
        {
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
            InitializeComponent();
            initValues();
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CurrentGame.Rating = e.NewValue;
        }

        private void ListView_SelectionChanged(
            object sender,
            SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            CurrentGame = (Game)lv.SelectedItem;
        }

        private void initValues()
        {
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

            Consoles.Add("PS4");
            Consoles.Add("Xbox");
            Consoles.Add("PC");
            Consoles.Add("Switch");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CurrentGame = new Game();
            Games.Add(CurrentGame);
        }

        private void add_image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Load an image";
            ofd.Filter = "All supported graphics|*.jpg;*.png;*.jpeg;*.svg|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                CurrentGame.CoverPath = ofd.FileName;
            }
        }
    }
}
