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
using Szyfrowanie;
using static Szyfrowanie.szyfr;



namespace Szyfrowanie
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Przycisk_Click(object sender, RoutedEventArgs e)
        {
            string text = TextInput.Text;
            int klucz = 0;



            if (!int.TryParse(KeyInput.Text, out klucz))
            {
                MessageBox.Show("Klucz musi być liczbą całkowitą.");
                return;
            }
            if (Szyfr.IsChecked == true)
            {
                Wynik.Text = Szyfring(text, klucz);
            }
            else if (OdSzyfr.IsChecked == true)
            {
                Wynik.Text = NieSzyfring(text, klucz);
            }
        }
    }
}
