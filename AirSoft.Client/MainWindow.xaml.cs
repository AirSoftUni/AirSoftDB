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
<<<<<<< HEAD
        ObservableCollection<AirSoftContext> context = new ObservableCollection<AirSoftContext>();
=======

>>>>>>> 8ed3579218058925925aa93bdd9fe7e7aff80b76

        AirSoftStore store = new AirSoftStore();
        public MainWindow()
        {
            InitializeComponent();
<<<<<<< HEAD
 
=======

<<<<<<< HEAD
            //LoadPlayers();
            //LoadGames();
=======

            //store.Initialize();




            // store.Initialize();
>>>>>>> 8ed3579218058925925aa93bdd9fe7e7aff80b76

>>>>>>> 43413099324e24d8558c87bf62b575f861068423

            DataContext = new
            {
<<<<<<< HEAD
                players = new ObservableCollection<Player>(store.GetAllPlayers()),
                games = new ObservableCollection<Game>(store.GetAllGames()),
                teams = new ObservableCollection<Team>(store.GetAllTeams())
=======
                players = store.GetAllPlayers(),
                games = store.GetAllGames(),
                teams = store.GetAllTeams(),
>>>>>>> 8ed3579218058925925aa93bdd9fe7e7aff80b76
            };



<<<<<<< HEAD

        public void LoadPlayers()
=======
        }   

        private void LoadPlayers()
        {
            DataContext = new ObservableCollection<Player>(this.store.GetAllPlayers());
        }
        private void LoadGames()
>>>>>>> 8ed3579218058925925aa93bdd9fe7e7aff80b76
        {
            DataContext = new ObservableCollection<Game>(this.store.GetAllGames());
        }
<<<<<<< HEAD
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
=======
       

        private void AddNewPlayer_Click(object sender, RoutedEventArgs e)
        { 
            ((ObservableCollection<Player>)DataContext).Add(this.store.AddNewPlayer());
        }

        
>>>>>>> 8ed3579218058925925aa93bdd9fe7e7aff80b76
    }
}
