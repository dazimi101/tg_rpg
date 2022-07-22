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
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RpgSession _game;
        public MainWindow()
        {
            // InitializeComponent is for the GUI window
            InitializeComponent();
            _game = new RpgSession();

            // Set context for binding in XAML file
            DataContext = _game;
        }
        private void OnClick_MoveUp(object sender, RoutedEventArgs e)
        {
            _game.MoveUp();
        }
        private void OnClick_MoveLeft(object sender, RoutedEventArgs e)
        {
            _game.MoveLeft();
        }
        private void OnClick_MoveDown(object sender, RoutedEventArgs e)
        {
            _game.MoveDown();
        }
        private void OnClick_MoveRight(object sender, RoutedEventArgs e)
        {
            _game.MoveRight();
        }
    }
}
