using AirSoft.Data;
using AirSoft.Data.Stores;
using AirSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirSoft.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AirSoftStore store = new AirSoftStore();
        public MainWindow()
        {
            InitializeComponent();

            // store.Initialize();
                
            DataContext = store.GetAllPlayers();
                
            
        }
    }
}
