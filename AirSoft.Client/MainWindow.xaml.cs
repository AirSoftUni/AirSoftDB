using AirSoft.Data;
using AirSoft.Data.Stores;
using AirSoft.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace AirSoft.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<AirSoftContext> context = new ObservableCollection<AirSoftContext>();

        AirSoftStore store = new AirSoftStore();
        public MainWindow()
        {
            InitializeComponent();

            //LoadPlayers();
            //LoadGames();


            DataContext = new
            {
                players = new ObservableCollection<Player>(store.GetAllPlayers()),
                games = new ObservableCollection<Game>(store.GetAllGames()),
                teams = new ObservableCollection<Team>(store.GetAllTeams())
            };


        }


        public void LoadPlayers()
        {
            DataContext = new ObservableCollection<Player>(store.GetAllPlayers());
        }
        public void LoadGames()
        {
            DataContext = new ObservableCollection<Game>(store.GetAllGames());
        }


        private void AddNewPlayer_Click(object sender, RoutedEventArgs e)
        {

            ((ObservableCollection<Player>)DataContext).Add(this.store.AddNewPlayer());
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            this.store.SaveChanges();
        }
    }
}
