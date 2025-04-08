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

namespace GGGGG.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = loginTb.Text;
            var password = PasswordTb.Password;
            var loginUser = "Admin";
            var passwordUser = "Admin";
            if (login == loginUser && password == passwordUser)
            {
                MessageBox.Show("Здравствуй админ");
                NavigationService.Navigate(new AnketaPage());
            }
            else
            {
                MessageBox.Show("Уолтер убери свой ****");
            }
        }
    }
}
