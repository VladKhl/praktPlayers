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
    /// Логика взаимодействия для AdmPlayProf.xaml
    /// </summary>
    public partial class AdmPlayProf : Page
    {
        playersdbEntities dataEntities = new playersdbEntities();
        bool photochange = false;
        byte [] photo;
        public AdmPlayProf()
        {
            InitializeComponent();
            var im = (
                from player in dataEntities.Players join ima in dataEntities.Photos on player.ID_photo equals ima.ID_photo 
                where player.ID_player == AdmTP.admid 
                select ima.Photo).First();
            playim.Source = ByteArrayToImage(im);
            Surname_input();
            Name_input();
            Middlename_input();
            Cost_input();
            Number_input();
            Club_input();
            DateBirth_input();
            Graj_input();
            Height_input();
            Weight_input();
            Position_input();
            Placebirth_input();
            Workingleg_input();
            Contract_input();
            Natteam_input();
            Agency_input();
            Sponsor_input();
            Pengoal_input();
            kk_input();
            jk_input();
            goal_input();
            gp_input();
        }

        public BitmapSource ByteArrayToImage(byte[] buffer)
        {
            using (var stream = new MemoryStream(buffer))
            {
                return BitmapFrame.Create(stream,
                    BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            }
        }
        private void gp_input()
        {
            var gp = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Assists).First();
            if (gp != null)
            {
                gpl.Text = gp.ToString();
            }
        }
        private void goal_input()
        {
            var go = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Goals).First();
            if (go != null)
            {
                goal.Text = go.ToString();
            }
        }
        private void jk_input()
        {
            var jk = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Yellow_card).First();
            if (jk != null)
            {
                jkl.Text = jk.ToString();
            }
        }
        private void kk_input()
        {
            var kk = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Red_card).First();
            if (kk != null)
            {
                kkl.Text = kk.ToString();
            }
        }
        private void Pengoal_input()
        {
            var pg = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Penalty_goals).First();
            if (pg != null)
            {
                pengoal.Text = pg.ToString();
            }
        }
        private void Sponsor_input()
        {
            var sp = (from player in dataEntities.Players join spo in dataEntities.Technical_sponsors on player.ID_technical_sponsor equals spo.ID_technical_sponsor where player.ID_player == AdmTP.admid select spo.Name_sponsor).First();
            techsp.Text = sp.ToString();
            var gg = dataEntities.Technical_sponsors.ToList();
            techsp.ItemsSource = gg;
            techsp.DisplayMemberPath = "Name_sponsor";
        }
        private void Agency_input()
        {
            var ag = (from player in dataEntities.Players join age in dataEntities.Agency on player.ID_agency equals age.ID_agency where player.ID_player == AdmTP.admid select age.Name_agency).First();
            agency.Text = ag.ToString();
            var gg = dataEntities.Agency.ToList();
            agency.ItemsSource = gg;
            agency.DisplayMemberPath = "Name_agency";
        }
        private void Natteam_input()
        {
            var nt = (from player in dataEntities.Players join natt in dataEntities.National_teams on player.ID_national_team equals natt.ID_national_team where player.ID_player == AdmTP.admid select natt.Name_national_team).First();
            natteam.Text = nt.ToString();
            var gg = dataEntities.National_teams.ToList();
            natteam.ItemsSource = gg;
            natteam.DisplayMemberPath = "Name_national_team";
        }
        private void Contract_input()
        {
            var cn = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Contract_date).First();
            if (cn != null)
            {
                contract.Text = cn.ToString().Substring(0, 10);
            }
        }
        private void Workingleg_input()
        {
            var wl = (from player in dataEntities.Players join wol in dataEntities.Working_leg on player.ID_working_leg equals wol.ID_working_leg where player.ID_player == AdmTP.admid select wol.Name).First();
            workingleg.Text = wl.ToString();
            var gg = dataEntities.Working_leg.ToList();
            workingleg.ItemsSource = gg;
            workingleg.DisplayMemberPath = "Name";
        }
        private void Surname_input()
        {
            var surn = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Surname).First();
            if (surn != null)
            {
                surname.Text = surn.ToString();
            }
        }

        private void Name_input()
        {
            var nam = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Name).First();
            if (nam != null)
            {
                name.Text = nam.ToString();
            }
        }

        private void Middlename_input()
        {
            var midn = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Middlename).First();
            if (midn != null)
            {
                middlename.Text = midn.ToString();
            }
        }

        private void Cost_input()
        {
            var cos = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Cost).First();
            if (cos != null)
            {
                cost.Text = cos.ToString();
            }
        }
        private void Number_input()
        {
            var num = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Play_number).First();
            if (num != null)
            {
                number.Text = num.ToString();
            }
        }
        private void Club_input()
        {

            var clu = (
                from player in dataEntities.Players 
                        join ph in dataEntities.Clubs on player.ID_club 
                        equals ph.ID_club 
                where player.ID_player == AdmTP.admid 
                select ph.Photo_club).First();

            var clu2 = (
                from player in dataEntities.Players 
                        join ph in dataEntities.Clubs on player.ID_club 
                        equals ph.ID_club 
                where player.ID_player == AdmTP.admid 
                select ph.Name_club).First();

            clubim.Source = ByteArrayToImage(clu);
            clubch.Text = clu2.ToString();

            var gg = dataEntities.Clubs.ToList();
            clubch.ItemsSource = gg;
            clubch.DisplayMemberPath = "Name_club";
        }

        private void DateBirth_input()
        {
            var dateb = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Date_birth).First();
            if (dateb != null)
            {
                birthday.Text = dateb.ToString().Substring(0, 10);
            }
        }

        private void Graj_input()
        {
            var gra = (from player in dataEntities.Players join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation where player.ID_player == AdmTP.admid select nat.Name).First();
            graj.Text = gra.ToString();
            var gg = dataEntities.Nations.ToList();
            graj.ItemsSource = gg;
            graj.DisplayMemberPath = "Name";
        }

        private void Height_input()
        {
            var hei = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Height).First();
            if (hei != null)
            {
                height.Text = hei.ToString();
            }
        }

        private void Weight_input()
        {
            var wei = (from player in dataEntities.Players where player.ID_player == AdmTP.admid select player.Weight).First();
            if (wei != null)
            {
                weight.Text = wei.ToString();
            }
        }

        private void Position_input()
        {
            var posit = (from player in dataEntities.Players join pos in dataEntities.Position on player.ID_position equals pos.ID_position where player.ID_player == AdmTP.admid select pos.Name_position).First();
            position.Text = posit.ToString();
            var gg = dataEntities.Position.ToList();
            position.ItemsSource = gg;
            position.DisplayMemberPath = "Name_position";
        }

        private void Placebirth_input()
        {
            var pb = from player in dataEntities.Players join plb in dataEntities.Place_birth on player.ID_place_birth equals plb.ID_place_birth where player.ID_player == AdmTP.admid select plb.Name;
            placebirth.Text = pb.First().ToString();
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

        private void sumbit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Players pl = (from p in dataEntities.Players
                              where p.ID_player == AdmTP.admid
                              select p).First();
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
                if (photochange == true)
                {
                    Photos pho = new Photos();
                    pho.Photo = photo;
                    dataEntities.Photos.Add(pho);
                    dataEntities.SaveChanges();
                    pl.ID_photo = pho.ID_photo;
                }
                dataEntities.SaveChanges();
                NavigationService.Navigate(new AdmTP());
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void playim_MouseEnter(object sender, MouseEventArgs e)
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
                photochange = true;
                photo = File.ReadAllBytes(ofdPicture.FileName);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxExit = MessageBox.Show("Удалить игрока?", "Удаление", MessageBoxButton.YesNo);
            if (messageBoxExit == MessageBoxResult.Yes)
            {
                Players play = (from p in dataEntities.Players
                              where p.ID_player == AdmTP.admid
                              select p).First();
                Photos ph = (from h in dataEntities.Photos
                             join p in dataEntities.Players
                             on h.ID_photo equals p.ID_photo
                             where p.ID_player == AdmTP.admid
                             select h).First();
                dataEntities.Players.Remove(play);
                dataEntities.Photos.Remove(ph);
                dataEntities.SaveChanges();
                NavigationService.Navigate(new AdmTP());
            }
        }
    }
}
