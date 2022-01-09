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
using System.Data.Entity.Core.Objects;

namespace Sportiroda_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        sportirodaEntities dataEntities = new sportirodaEntities();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from verseny in dataEntities.OsszesAdat
                //where verseny.nev == "Maraton"
            orderby verseny.vnev
            select new { verseny.vnev, verseny.szuldatum, verseny.nem, verseny.nev, verseny.datum, verseny.kezdesido, verseny.nevezesi_dij, verseny.szintido };

            grdNevezesek.ItemsSource = query.ToList();
            grdNevezesek.Columns[0].Header = "Versenyző neve";
            grdNevezesek.Columns[1].Header = "Kora";
            grdNevezesek.Columns[2].Header = "Neme";
            grdNevezesek.Columns[3].Header = "Verseny Neve";
            grdNevezesek.Columns[4].Header = "Dátum";
            grdNevezesek.Columns[5].Header = "Kezdési Idő";
            grdNevezesek.Columns[6].Header = "Nevezési Díj";
            grdNevezesek.Columns[7].Header = "Szintidő";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
