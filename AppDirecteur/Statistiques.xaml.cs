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
using System.Windows.Shapes;

namespace AppDirecteur_PPE3
{
    /// <summary>
    /// Logique d'interaction pour Statistiques.xaml
    /// </summary>
    public partial class Statistiques : Window
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private void btn_theme_pStat_Click(object sender, RoutedEventArgs e)
        {
            Theme_Obstacle T_O = new Theme_Obstacle();
            T_O.Show();
        }

        private void btn_avis_pStat_Click(object sender, RoutedEventArgs e)
        {
            Avis avis = new Avis();
            avis.Show();
        }

        private void btn_fermer_pStat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr_confirmation;
            mbr_confirmation = MessageBox.Show("Êtes-vous sur de vouloir quitter ?", "Fermeture", MessageBoxButton.YesNo);

            if (mbr_confirmation == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {
            if (rdb_Annecy.IsChecked == true | rdb_bonneville.IsChecked == true | rdb_chamonix.IsChecked == true | rdb_Thonon.IsChecked == true)
            {
                cb_salle.Visibility = Visibility.Visible;
                lbl_choixSalle.Visibility = Visibility.Visible;
                btn_valider.Visibility = Visibility.Hidden;
            }
        }

        private void cb_salle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_salle.SelectedIndex != -1)
            {
                lbl_creneau.Visibility = Visibility.Visible;
                list_creneau.Visibility = Visibility.Visible;
                Date_choixDate.Visibility = Visibility.Visible;
                lbl_precision.Visibility = Visibility.Visible;
            }
        }

        private void Date_choixDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            lbl_nbutilisation.Visibility = Visibility.Visible;
            lbl_nb.Visibility = Visibility.Visible;
            btn_modifier.Visibility = Visibility.Visible;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult mbr_confirmation;
            mbr_confirmation = MessageBox.Show("Êtes-vous sur de vouloir quitter ?", "Fermeture", MessageBoxButton.YesNo);
            if (mbr_confirmation == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
