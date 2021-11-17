using dbplayers.DB;
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
using System.Drawing;

namespace dbplayers
{
    /// <summary>
    /// Логика взаимодействия для PlayerProf.xaml
    /// </summary>
    public partial class PlayerProf : Page
    {
        playersdbEntities dataEntities = new playersdbEntities();
        public PlayerProf()
        {
            InitializeComponent();
            var im = (from player in dataEntities.Players join ima in dataEntities.Photos on player.ID_photo equals ima.ID_photo where player.ID_player == TablePlayers.id select ima.Photo).First();
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
            var gp = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Assists).First();
            if (gp != null)
            {
                gpl.Content = gp.ToString();
            }
        }
        private void goal_input()
        {
            var go = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Goals).First();
            if (go != null)
            {
                goal.Content = go.ToString();
            }
        }
        private void jk_input()
        {
            var jk = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Yellow_card).First();
            if (jk != null)
            {
                jkl.Content = jk.ToString();
            }
        }
        private void kk_input()
        {
            var kk = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Red_card).First();
            if (kk != null)
            {
                kkl.Content = kk.ToString();
            }
        }
        private void Pengoal_input()
        {
            var pg = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Penalty_goals).First();
            if (pg != null)
            {
                pengoal.Content = pg.ToString();
            }
        }
        private void Sponsor_input()
        {
            var sp = (from player in dataEntities.Players join spo in dataEntities.Technical_sponsors on player.ID_technical_sponsor equals spo.ID_technical_sponsor where player.ID_player == TablePlayers.id select spo.Name_sponsor).First();
            techsp.Content = sp.ToString();
        }
        private void Agency_input()
        {
            var ag = (from player in dataEntities.Players join age in dataEntities.Agency on player.ID_agency equals age.ID_agency where player.ID_player == TablePlayers.id select age.Name_agency).First();
            agency.Content = ag.ToString();
        }
        private void Natteam_input()
        {
            var nt = (from player in dataEntities.Players join natt in dataEntities.National_teams on player.ID_national_team equals natt.ID_national_team where player.ID_player == TablePlayers.id select natt.Name_national_team).First();
            natteam.Content = nt.ToString();
        }
        private void Contract_input()
        {
            var cn = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Contract_date).First();
            if (cn != null)
            {
                contract.Content = cn.ToString().Substring(0, 10);
            }
        }
        private void Workingleg_input()
        {
            var wl = (from player in dataEntities.Players join wol in dataEntities.Working_leg on player.ID_working_leg equals wol.ID_working_leg where player.ID_player == TablePlayers.id select wol.Name).First();
            workingleg.Content = wl.ToString();
        }
        private void Surname_input()
        {
            var surn = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Surname).First();
            if (surn != null)
            {
                surname.Content = surn.ToString();
            }
        }

        private void Name_input()
        {
            var nam = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Name).First();
            if (nam != null)
            {
                name.Content = nam.ToString();
            }
        }

        private void Middlename_input()
        {
            var midn = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Middlename).First();
            if (midn != null)
            {
                middlename.Content = midn.ToString();
            }
        }

        private void Cost_input()
        {
            var cos = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Cost).First();
            if (cos != null)
            {
                cost.Content = cos.ToString();
            }
        }
        private void Number_input()
        {
            var num = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Play_number).First();
            if (num != null)
            {
                number.Content = num.ToString();
            }
        }
        private void Club_input()
        {
            var clu = (from player in dataEntities.Players join ph in dataEntities.Clubs on player.ID_club equals ph.ID_club where player.ID_player == TablePlayers.id select ph.Photo_club).First();
            clubim.Source = ByteArrayToImage(clu);
        }

        private void DateBirth_input()
        {
            var dateb = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Date_birth).First();
            if (dateb != null)
            {
                birthday.Content = dateb.ToString().Substring(0, 10);
            }
        }

        private void Graj_input()
        {
            var gra = (from player in dataEntities.Players join nat in dataEntities.Nations on player.ID_nation equals nat.ID_nation where player.ID_player == TablePlayers.id select nat.Name).First();
            graj.Content = gra.ToString();
        }

        private void Height_input()
        {
            var hei = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Height).First();
            if (hei != null)
            {
                height.Content = hei.ToString();
            }
        }

        private void Weight_input()
        {
            var wei = (from player in dataEntities.Players where player.ID_player == TablePlayers.id select player.Weight).First();
            if (wei != null)
            {
                weight.Content = wei.ToString();
            }
        }

        private void Position_input()
        {
            var posit = (from player in dataEntities.Players join pos in dataEntities.Position on player.ID_position equals pos.ID_position where player.ID_player == TablePlayers.id select pos.Name_position).First();
            position.Content = posit.ToString();
        }

        private void Placebirth_input()
        {
            var pb = (from player in dataEntities.Players join plb in dataEntities.Place_birth on player.ID_place_birth equals plb.ID_place_birth where player.ID_player == TablePlayers.id select plb.Name).First();
            placebirth.Content = pb.ToString();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
