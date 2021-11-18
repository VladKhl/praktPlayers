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
    public partial class AdmAddPlay : Page
    {
        playersdbEntities dataEntities = new playersdbEntities();
        byte[] photo;
        bool choosephoto = false;
        public AdmAddPlay()
        {
            InitializeComponent();
            Club_input();
            Graj_input();
            Position_input();
            Placebirth_input();
            Workingleg_input();
            Natteam_input();
            Agency_input();
            Sponsor_input();
        }
        public BitmapSource ByteArrayToImage(byte[] buffer)
        {
            using (var stream = new MemoryStream(buffer))
            {
                return BitmapFrame.Create(stream,
                    BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            }
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
        private void Workingleg_input()
        {
            var gg = dataEntities.Working_leg.ToList();
            workingleg.ItemsSource = gg;
            workingleg.DisplayMemberPath = "Name";
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

        private void Position_input()
        {
            var gg = dataEntities.Position.ToList();
            position.ItemsSource = gg;
            position.DisplayMemberPath = "Name_position";
        }

        private void Placebirth_input()
        {
            var gg = dataEntities.Place_birth.ToList();
            placebirth.ItemsSource = gg;
            placebirth.DisplayMemberPath = "Name";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void clubch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = clubch.SelectedItem as Clubs;
            var clu = (
             from ph in dataEntities.Clubs
             where ph.Name_club == gg.Name_club
             select ph.Photo_club
             )
             .First();
            clubim.Source = ByteArrayToImage(clu);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Players pl = new Players();
                pl.Name = name.Text;
                pl.Surname = surname.Text;
                pl.Middlename = middlename.Text;
                pl.Play_number = int.Parse(number.Text);
                pl.Date_birth = Convert.ToDateTime(birthday.Text);
                pl.Cost = int.Parse(cost.Text);
                pl.Weight = int.Parse(weight.Text);
                pl.Height = int.Parse(height.Text);
                pl.Contract_date = Convert.ToDateTime(contract.Text);
                pl.Goals = int.Parse(goal.Text);
                pl.Assists = int.Parse(gpl.Text);
                pl.Penalty_goals = int.Parse(pengoal.Text);
                pl.Yellow_card = int.Parse(jkl.Text);
                pl.Red_card = int.Parse(kkl.Text);
                pl.ID_place_birth = (from pbi in dataEntities.Place_birth
                                     where pbi.Name == placebirth.Text
                                     select pbi.ID_place_birth).First();
                pl.ID_working_leg = (from wrl in dataEntities.Working_leg
                                     where wrl.Name == workingleg.Text
                                     select wrl.ID_working_leg).First();
                pl.ID_position = (from pos in dataEntities.Position
                                  where pos.Name_position == position.Text
                                  select pos.ID_position).First();
                pl.ID_club = (from clu in dataEntities.Clubs
                              where clu.Name_club == clubch.Text
                              select clu.ID_club).First();
                pl.ID_nation = (from nat in dataEntities.Nations
                                where nat.Name == graj.Text
                                select nat.ID_nation).First();
                pl.ID_national_team = (from natt in dataEntities.National_teams
                                       where natt.Name_national_team == natteam.Text
                                       select natt.ID_national_team).First();
                pl.ID_agency = (from age in dataEntities.Agency
                                where age.Name_agency == agency.Text
                                select age.ID_agency).First();
                pl.ID_technical_sponsor = (from spo in dataEntities.Technical_sponsors
                                           where spo.Name_sponsor == techsp.Text
                                           select spo.ID_technical_sponsor).First();
                Photos pho = new Photos();
                pho.Photo = photo;
                if (choosephoto == true)
                {
                    dataEntities.Photos.Add(pho);
                    dataEntities.SaveChanges();
                    pl.ID_photo = pho.ID_photo;
                    dataEntities.Players.Add(pl);
                    dataEntities.SaveChanges();
                    NavigationService.Navigate(new AdmTP());
                }
                else
                {
                    MessageBox.Show("Выберите фото");
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void addphoto_Click(object sender, RoutedEventArgs e)
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
                playim.Source = image;
                photo = File.ReadAllBytes(ofdPicture.FileName);
                choosephoto = true;
            }
        }
    }
}