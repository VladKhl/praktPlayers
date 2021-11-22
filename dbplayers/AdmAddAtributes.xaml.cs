using dbplayers.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AdmAddAtributes.xaml
    /// </summary>
    public partial class AdmAddAtributes : Page
    {
        playersdbEntities dataEntities = new playersdbEntities();
        byte[] photo;
        bool choosephoto = false;
        public AdmAddAtributes()
        {
            InitializeComponent();
            Club_input();
            Graj_input();
            Placebirth_input();
            Natteam_input();
            Agency_input();
            Sponsor_input();
        }

        private void backatr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdmAddPlay());
        }

        
        private void Sponsor_input()
        {
            var gg = dataEntities.Technical_sponsors.ToList();
            techsp.ItemsSource = gg;
            techsp.DisplayMemberPath = "Name_sponsor";
        }
        private void Agency_input()
        {
            var gg = dataEntities.Agency.ToList();
            agency.ItemsSource = gg;
            agency.DisplayMemberPath = "Name_agency";
        }
        private void Natteam_input()
        {
            var gg = dataEntities.National_teams.ToList();
            natteam.ItemsSource = gg;
            natteam.DisplayMemberPath = "Name_national_team";
        }
        private void Club_input()
        {
            var gg = dataEntities.Clubs.ToList();
            clubch.ItemsSource = gg;
            clubch.DisplayMemberPath = "Name_club";
        }

        private void Graj_input()
        {
            var gg = dataEntities.Nations.ToList();
            graj.ItemsSource = gg;
            graj.DisplayMemberPath = "Name";
        }

        private void Placebirth_input()
        {
            var gg = dataEntities.Place_birth.ToList();
            placebirth.ItemsSource = gg;
            placebirth.DisplayMemberPath = "Name";
        }

        private void chphoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;
            if (ofdPicture.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdPicture.FileName);
                image.EndInit();
                photo = File.ReadAllBytes(ofdPicture.FileName);
                choosephoto = true;
            }
        }

        private void addclub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(club.Text))
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    if (choosephoto == true)
                    {
                        Clubs clu = new Clubs();
                        clu.Name_club = club.Text;
                        clu.Photo_club = photo;
                        dataEntities.Clubs.Add(clu);
                        dataEntities.SaveChanges();
                        Club_input();
                        Graj_input();
                        Placebirth_input();
                        Natteam_input();
                        Agency_input();
                        Sponsor_input();
                        MessageBox.Show($"Клуб {clu.Name_club} добавлен");
                    }
                    else
                    {
                        MessageBox.Show("Выберите фото клуба");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void addnat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nat.Text))
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    Nations na = new Nations();
                    na.Name = nat.Text;
                    dataEntities.Nations.Add(na);
                    dataEntities.SaveChanges();
                    MessageBox.Show("Гражданство добавлено");
                    Club_input();
                    Graj_input();
                    Placebirth_input();
                    Natteam_input();
                    Agency_input();
                    Sponsor_input();
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void addplacebirth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(plbirth.Text))
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    Place_birth pb = new Place_birth();
                    pb.Name = plbirth.Text;
                    dataEntities.Place_birth.Add(pb);
                    dataEntities.SaveChanges();
                    MessageBox.Show("Место рождения добавлено");
                    Club_input();
                    Graj_input();
                    Placebirth_input();
                    Natteam_input();
                    Agency_input();
                    Sponsor_input();
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void addnatt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(team.Text))
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    National_teams nt = new National_teams();
                    nt.Name_national_team = team.Text;
                    dataEntities.National_teams.Add(nt);
                    dataEntities.SaveChanges();
                    MessageBox.Show("Сборная добавлена");
                    Club_input();
                    Graj_input();
                    Placebirth_input();
                    Natteam_input();
                    Agency_input();
                    Sponsor_input();
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void addagency_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(agen.Text))
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    Agency ag = new Agency();
                    ag.Name_agency = agen.Text;
                    dataEntities.Agency.Add(ag);
                    dataEntities.SaveChanges();
                    MessageBox.Show("Агент добавлен");
                    Club_input();
                    Graj_input();
                    Placebirth_input();
                    Natteam_input();
                    Agency_input();
                    Sponsor_input();
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void addsponsor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sponsor.Text))
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    Technical_sponsors ts = new Technical_sponsors();
                    ts.Name_sponsor = sponsor.Text;
                    dataEntities.Technical_sponsors.Add(ts);
                    dataEntities.SaveChanges();
                    MessageBox.Show("Спонсор добавлен");
                    Club_input();
                    Graj_input();
                    Placebirth_input();
                    Natteam_input();
                    Agency_input();
                    Sponsor_input();
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void delclub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gg = clubch.SelectedItem as Clubs;
                var clu =
                 (from ph in dataEntities.Clubs
                  where ph.Name_club == gg.Name_club
                  select ph).First();
                dataEntities.Clubs.Remove(clu);
                dataEntities.SaveChanges();
                MessageBox.Show("Клуб удален");
                Club_input();
                Graj_input();
                Placebirth_input();
                Natteam_input();
                Agency_input();
                Sponsor_input();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void delnat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gg = graj.SelectedItem as Nations;
                var clu =
                 (from ph in dataEntities.Nations
                  where ph.Name == gg.Name
                  select ph).First();
                dataEntities.Nations.Remove(clu);
                dataEntities.SaveChanges();
                MessageBox.Show("Гражданство удалено");
                Club_input();
                Graj_input();
                Placebirth_input();
                Natteam_input();
                Agency_input();
                Sponsor_input();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void delplacebirth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gg = placebirth.SelectedItem as Place_birth;
                var clu =
                 (from ph in dataEntities.Place_birth
                  where ph.Name == gg.Name
                  select ph).First();
                dataEntities.Place_birth.Remove(clu);
                dataEntities.SaveChanges();
                MessageBox.Show("Место рождения удалено");
                Club_input();
                Graj_input();
                Placebirth_input();
                Natteam_input();
                Agency_input();
                Sponsor_input();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void delnatteam_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gg = natteam.SelectedItem as National_teams;
                var clu =
                 (from ph in dataEntities.National_teams
                  where ph.Name_national_team == gg.Name_national_team
                  select ph).First();
                dataEntities.National_teams.Remove(clu);
                dataEntities.SaveChanges();
                MessageBox.Show("Сборная удалена");
                Club_input();
                Graj_input();
                Placebirth_input();
                Natteam_input();
                Agency_input();
                Sponsor_input();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void delagency_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gg = agency.SelectedItem as Agency;
                var clu =
                 (from ph in dataEntities.Agency
                  where ph.Name_agency == gg.Name_agency
                  select ph).First();
                dataEntities.Agency.Remove(clu);
                dataEntities.SaveChanges();
                MessageBox.Show("Агент удален");
                Club_input();
                Graj_input();
                Placebirth_input();
                Natteam_input();
                Agency_input();
                Sponsor_input();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void delsponsor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gg = techsp.SelectedItem as Technical_sponsors;
                var clu =
                 (from ph in dataEntities.Technical_sponsors
                  where ph.Name_sponsor == gg.Name_sponsor
                  select ph).First();
                dataEntities.Technical_sponsors.Remove(clu);
                dataEntities.SaveChanges();
                MessageBox.Show("Спонсор удален");
                Club_input();
                Graj_input();
                Placebirth_input();
                Natteam_input();
                Agency_input();
                Sponsor_input();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
        }
    }
}
