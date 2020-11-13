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
    /// Logique d'interaction pour Theme_Obstacle.xaml
    /// </summary>
    public partial class Theme_Obstacle : Window
    {
        public Theme_Obstacle()
        {
            InitializeComponent();
        }

        private void btn_stat_pTheme_Click(object sender, RoutedEventArgs e)
        {
            Statistiques Stat = new Statistiques();
            Stat.Show();
        }

        private void btn_avis_pTheme_Click(object sender, RoutedEventArgs e)
        {
            Avis avis = new Avis();
            avis.Show();
        }

        private void btn_fermer_pTheme_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr_confirmation;
            mbr_confirmation = MessageBox.Show("Êtes-vous sur de vouloir quitter ?", "Fermeture", MessageBoxButton.YesNo);

            if (mbr_confirmation == MessageBoxResult.Yes)
            {
                Close();
            }
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

        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {
            if (rdb_Annecy.IsChecked == true | rdb_bonneville.IsChecked == true | rdb_chamonix.IsChecked == true | rdb_thonon.IsChecked == true)
            {
                lbl_salle.Visibility = Visibility.Visible;
                cmb_salle.Visibility = Visibility.Visible;               
            }
        }

        private void cmb_salle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_salle.SelectedIndex != -1)
            {
                lbl_theme_actuelle.Visibility = Visibility.Visible;
                lbl_theme.Visibility = Visibility.Visible;
                lbl_obs.Visibility = Visibility.Visible;
                list_obs.Visibility = Visibility.Visible;
                rtc_modif.Visibility = Visibility.Visible;
                lbl_modif.Visibility = Visibility.Visible;
                lbl_choix_theme.Visibility = Visibility.Visible;
                lbl_ajoutmanuel_theme.Visibility = Visibility.Visible;
                cmb_choix_theme.Visibility = Visibility.Visible;
                txt_choix_theme.Visibility = Visibility.Visible;
                lbl_choix_obs.Visibility = Visibility.Visible;
                lbl_ajout_obs.Visibility = Visibility.Visible;
                list_choix_obs.Visibility = Visibility.Visible;
                txtb_choix_obs.Visibility = Visibility.Visible;
                btn_ajouter.Visibility = Visibility.Visible;
                btn_supprimer.Visibility = Visibility.Visible;           
            }
        }

        private void btn_ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_ajoutmanuel_theme.Content != null)
            {
                cmb_choix_theme.Items.Add(lbl_ajoutmanuel_theme.Content);
            }

            if (lbl_ajout_obs.Content != null)
            {
                list_choix_obs.Items.Add(lbl_ajout_obs.Content);
            }

            if (cmb_choix_theme.SelectedIndex != -1)
            {
                lbl_theme.Content = cmb_choix_theme.SelectedItem;
            }

            if (list_choix_obs.SelectedIndex != -1)
            {
                list_obs.Items.Add(list_choix_obs.SelectedItems);
            }
        }

        private void btn_supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (cmb_choix_theme.SelectedIndex != -1)
            {
                cmb_choix_theme.Items.Remove(cmb_choix_theme.SelectedItem);
            }

            if (list_choix_obs.SelectedIndex != -1)
            {
                list_obs.Items.Remove(list_choix_obs.SelectedItems);
            }
        }
    }
}
