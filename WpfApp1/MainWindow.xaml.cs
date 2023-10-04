using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
using System.Xml.Linq;

namespace WpfApp1
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

        private string Plec()
        {
            string plec = "Mężczyzna";
            if (m.IsChecked == true)
            {
                plec = "Mężczyzna";
            }
            else if (k.IsChecked == true)
            {
                plec = "Kobieta";
            }
            return plec;
        }

        private string Zainteresowania()
        {
            string zainteresowania = "";
            
            if (komputer.IsChecked == true)
            {
                zainteresowania = zainteresowania + "\n " + komputer.Content;
            }

            if (sport.IsChecked == true)
            {
                zainteresowania = zainteresowania + "\n " + sport.Content;
            }

            if (ksiazki.IsChecked == true)
            {
                zainteresowania = zainteresowania + "\n " + ksiazki.Content;
            }

            if (programowanie.IsChecked == true)
            {
                zainteresowania = zainteresowania + "\n " + programowanie.Content;
            }

            return zainteresowania;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".jpg";

            fileDialog.ShowDialog();
            try
            {
                string imie = i.Text;
                string nazwisko = n.Text;
                string data = d.Text;

                string zain = Zainteresowania();

                if(zain == "") 
                {
                    zain = " \n Brak zainteresowań";
                }

                if(imie != String.Empty && nazwisko != String.Empty && data != String.Empty)
                {
                    label.Content = $" Imie: {imie} \n\r Nazwisko: {nazwisko} \n\r Data urodzenia: {data} \n\r Płeć: {Plec()} \n\r Zainteresowania: {zain}";
                    img.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath(fileDialog.FileName), UriKind.RelativeOrAbsolute));
                }
                else
                {
                    label.Content = "Wypełnij wszystkie wymagane pola!";
                }
            }
            catch(Exception ex)
            {
                label.Content = "Błędny format lub nie znaleziono pliku!";
            }
        }
    }
}
