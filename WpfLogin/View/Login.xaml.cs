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
using WpfLogin.Model;

namespace WpfLogin.View
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
         
        {
            if (Model.Authentification.Authentifier(txtCompte.Text, txtMotDePasse.ToString()))
            {
                this.Hide();
                MainWindow fenPrincipale = new MainWindow();
                fenPrincipale.Show();
               
            }
           
        }
        

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
