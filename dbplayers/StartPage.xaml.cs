using dbplayers.DB;
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

namespace dbplayers
{

    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        playersdbEntities dataEntities = new playersdbEntities();
        public StartPage()
        {
            InitializeComponent();
        }

        private void Window_load(object sender, RoutedEventArgs e)
        {
            login.Text = "ЛОГИН";
            password.Text = "ПАРОЛЬ";
        }

        private void entry_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var log = (from auf in dataEntities.Accounts where auf.login == login.Text.ToLower() where auf.password == password.Text select auf.ID_role).First();
                if (log == 1401)
                {
                    MessageBox.Show("Вы вошли в админ-аккаунт");
                    NavigationService.Navigate(new AdmTP());
                }
                else
                {
                    NavigationService.Navigate(new TablePlayers());
                }
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text) || (login.Text == "ЛОГИН") || (password.Text == "ПАРОЛЬ"))
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                    int cnt = 0;
                    var log = (from auf in dataEntities.Accounts
                               where auf.login == login.Text.ToLower()
                               select auf.login).ToList();
                    foreach (var logi in log)
                    {
                        if (logi == login.Text.ToLower().Trim())
                        {
                            MessageBox.Show("Аккаунт с такими данными уже существует");
                            cnt++;
                        }
                    }
                    if (cnt == 0)
                    {
                        Accounts acc = new Accounts
                        {
                            login = login.Text.ToLower(),
                            password = password.Text,
                            ID_role = 1402
                        };
                        dataEntities.Accounts.Add(acc);
                        dataEntities.SaveChanges();
                        MessageBox.Show("Аккаунт зарегестрирован");
                    }
            }
        }
        private void login_enter(object sender, EventArgs e)
        {
            if (login.Text == "ЛОГИН")
            login.Clear();
        }

        private void password_enter(object sender, EventArgs e)
        {
            if (password.Text == "ПАРОЛЬ")
            password.Clear();
        }
    }
}
