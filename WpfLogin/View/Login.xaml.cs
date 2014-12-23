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
using System.DirectoryServices;

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
            try
            {

                DirectoryEntry Ldap = new DirectoryEntry("ldaps://dc3-2k8.bvg-mali.local", "fodiarra", "Sankoura!!1");
                MessageBox.Show("Connection OK");

            }

            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
           
        }
        

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
