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
    /// Логика взаимодействия для AdmTP.xaml
    /// </summary>
    public partial class AdmTP : Page
    {
        playersdbEntities dataEntities = new playersdbEntities();
        public static int admid { get; set; }
        public AdmTP()
        {
            InitializeComponent();
            data_loaded();
        }

        private void data_loaded()
        {
            var query =
            from player in dataEntities.Players
            join club in dataEntities.Clubs on player.ID_club equals club.ID_club
            join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
            join pos in dataEntities.Position on player.ID_position equals pos.ID_position
            join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
            select new
            {
                ID = player.ID_player,
                Фамилия = player.Surname,
                Имя = player.Name,
                Отчество = player.Middlename,
                Рост = player.Height,
                Вес = player.Weight,
                Нога = worl.Name,
                Позиция = pos.Name_position,
                Клуб = club.Name_club,
                Гражданство = nat.Name,
                Голы = player.Goals,
                Ассисты = player.Assists,
                ЖК = player.Yellow_card,
                КК = player.Red_card,
                Родился = player.Date_birth.ToString().Substring(0, 10),
                Цена = player.Cost,
            };
            tablepl.ItemsSource = query.ToList();
        }

        private void found_Click(object sender, RoutedEventArgs e)
        {
            if (parfoun.SelectedIndex == 0)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where player.Name.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (parfoun.SelectedIndex == 1)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where player.Surname.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (parfoun.SelectedIndex == 2)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where player.Middlename.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (parfoun.SelectedIndex == 3)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where worl.Name.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (parfoun.SelectedIndex == 4)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where pos.Name_position.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (parfoun.SelectedIndex == 5)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where club.Name_club.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (parfoun.SelectedIndex == 6)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                where nat.Name.Contains(valapr.Text)
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
        }

        private void group_Click(object sender, RoutedEventArgs e)
        {
            if (pargr.SelectedIndex == 0)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Goals descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 1)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Assists descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 2)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Height descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 3)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Weight descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 4)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Date_birth descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 5)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Cost descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 6)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Yellow_card descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
            else if (pargr.SelectedIndex == 7)
            {
                var query =
                from player in dataEntities.Players
                join club in dataEntities.Clubs on player.ID_club equals club.ID_club
                join worl in dataEntities.Working_leg on player.ID_working_leg equals worl.ID_working_leg
                join pos in dataEntities.Position on player.ID_position equals pos.ID_position
                join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation
                orderby player.Red_card descending
                select new
                {
                    ID = player.ID_player,
                    Фамилия = player.Surname,
                    Имя = player.Name,
                    Отчество = player.Middlename,
                    Рост = player.Height,
                    Вес = player.Weight,
                    Нога = worl.Name,
                    Позиция = pos.Name_position,
                    Клуб = club.Name_club,
                    Гражданство = nat.Name,
                    Голы = player.Goals,
                    Ассисты = player.Assists,
                    ЖК = player.Yellow_card,
                    КК = player.Red_card,
                    Родился = player.Date_birth.ToString().Substring(0, 10),
                    Цена = player.Cost,
                };
                tablepl.ItemsSource = query.ToList();
            }
        }

        private void parfoun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valapr.Text = "";
        }

        private void profileopen(object sender, MouseButtonEventArgs e)
        {
            string idval = tablepl.SelectedItem.ToString().Substring(7, 3);
            admid = Convert.ToInt32(idval);
            NavigationService.Navigate(new AdmPlayProf());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxExit = MessageBox.Show("Выйти из аккаунта?", "Выход", MessageBoxButton.YesNo);
            if (messageBoxExit == MessageBoxResult.Yes)
                NavigationService.Navigate(new StartPage());
        }
    }
}
