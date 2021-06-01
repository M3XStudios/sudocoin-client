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

namespace SudoCoin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadAPI_Click(object sender, RoutedEventArgs e)
        {
            ReadAPI objReadAPI = new ReadAPI();
            this.Visibility = Visibility.Hidden;
            objReadAPI.Show();
        }

        private void Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            SignUp objSignUp = new SignUp();
            this.Visibility = Visibility.Hidden;
            objSignUp.Show();
        }

        private void Available_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ERROR: Area defined as non-accesable by Common.Cursor[No]");
        }

        private void StoreOpen(object sender, RoutedEventArgs e)
        {
            PopUpStore objPopUpStore = new PopUpStore();
            this.Visibility = Visibility.Hidden;
            objPopUpStore.Show();
        }
    }
}
