using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DeerCafe_Repo.Services;
using DeerCafe_Repo.Services.Impl;

namespace DeerCafe
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

        private void btnLogin_CLick(object sender, RoutedEventArgs e)
        {
            // call Authenticate method from AuthenticationService
            IAuthentication authentication = new AuthenticationService();
            string token = authentication.Authenticate(txtUsername.Text, txtPassword.Password);
            // debug
            // show message box with token
            MessageBox.Show(token);
            this.Close();
        }
    }
}