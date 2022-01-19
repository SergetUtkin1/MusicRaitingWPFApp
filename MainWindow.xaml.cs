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

namespace MusicRaiting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToAddWin_Click(object sender, RoutedEventArgs e)
        {
            AddingWin win = new AddingWin();
            win.Show();
            Close();
        }

        private void ToCheckWin_Click(object sender, RoutedEventArgs e)
        {
            CheckMus win = new CheckMus();
            win.Show();
            Close();
        }
    }
}
