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
using System.Data.SqlClient;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Login;
        public int ttr = 0, strrrr=0;
        public string IDID;
        public string Passwords;
        public string status;
        public string LoginDB;
        public string PasswordsDB;
        public bool islegal=false;
        public int Horses = 0, Hor1=0;
        public int TOR=0;
        public string Name, Age, Logineses, paswordeses,sTATUS,idname,idpass,idlog,idstatus;
        public int idididid = 0;
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation opacityAnim1 = new DoubleAnimation();
            opacityAnim1.From = 0.0;
            opacityAnim1.To = 1;
            opacityAnim1.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            HellowButton3.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            HellowButton4.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            //
            ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-543, 14, 0, 0);
            thicknessAnimation1.To = new Thickness(60,14, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(311, 4, -547, 0);
            thicknessAnimation1.To = new Thickness(62, 4, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textpass.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation3 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(131, -167, 0, 0);
            thicknessAnimation1.To = new Thickness(131, 28, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1.2);
            HellowButton3.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation4 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(73, 210, 0, -169);
            thicknessAnimation1.To = new Thickness(73, 16, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            HellowButton4.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(155, 518, 0, -473);
            thicknessAnimation1.To = new Thickness(155, 28, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            ButLog.BeginAnimation(MarginProperty, thicknessAnimation1);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            DoubleAnimation opacityAnim131 = new DoubleAnimation();
            opacityAnim131.From = 1;
            opacityAnim131.To = 0.0;
            opacityAnim131.Duration = TimeSpan.FromSeconds(2);
            Add.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Delete.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Redakt.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Listinfo.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            //
            ThicknessAnimation thicknessAnimation91 = new ThicknessAnimation();
            thicknessAnimation91.From = new Thickness(87, 83, 0, 0);
            thicknessAnimation91.To = new Thickness(87, -346, 0, 0);
            thicknessAnimation91.Duration = TimeSpan.FromSeconds(1);
            Add.BeginAnimation(MarginProperty, thicknessAnimation91);
            //
            ThicknessAnimation thicknessAnimation92 = new ThicknessAnimation();
            thicknessAnimation92.From = new Thickness(87, 175, 0, 0);
            thicknessAnimation92.To = new Thickness(87, -252, 0, 0);
            thicknessAnimation92.Duration = TimeSpan.FromSeconds(1);
            Delete.BeginAnimation(MarginProperty, thicknessAnimation92);
            //
            ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
            thicknessAnimation93.From = new Thickness(0, 57, 0, 0);
            thicknessAnimation93.To = new Thickness(123, -122, 0, 0);
            thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
            Exit.BeginAnimation(MarginProperty, thicknessAnimation93);
            //
            ThicknessAnimation thicknessAnimation94 = new ThicknessAnimation();
            thicknessAnimation94.From = new Thickness(87, 132, 0, 0);
            thicknessAnimation94.To = new Thickness (87, -299, 0, 0);
            thicknessAnimation94.Duration = TimeSpan.FromSeconds(1);
            Redakt.BeginAnimation(MarginProperty, thicknessAnimation94);
            //
            ThicknessAnimation thicknessAnimation95 = new ThicknessAnimation();
            thicknessAnimation95.From = new Thickness(24, 49, 0, 0);
            thicknessAnimation95.To = new Thickness (24, -338, 0, 0);
            thicknessAnimation95.Duration = TimeSpan.FromSeconds(1);
            Listinfo.BeginAnimation(MarginProperty, thicknessAnimation95);



            ////////////////////////////////////////////////////////////////////////////////


            TextName.Clear();
            TextLog.Clear();
            Textpass.Clear();
            DoubleAnimation opacityAnim1 = new DoubleAnimation();
            opacityAnim1.From = 1;
            opacityAnim1.To = 0.0;
            opacityAnim1.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            //
            ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(60, 14, 0, 0);
            thicknessAnimation1.To = new Thickness(-543, 14, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(62, 4, 0, 0);
            thicknessAnimation1.To = new Thickness(311, 4, -547, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textpass.BeginAnimation(MarginProperty, thicknessAnimation2);
            //
            ////////////////////////////////
            DoubleAnimation opacityAnim2 = new DoubleAnimation();
            opacityAnim2.From = 0.0;
            opacityAnim2.To = 1;
            opacityAnim2.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAbelAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAbelName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAblstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextStatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            //TextidPass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextidLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextidName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            Textidstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            //
            ThicknessAnimation thicknessAnimation12 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(60, -358, 0, 0);
            thicknessAnimation1.To = new Thickness(60, 14, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation22 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(62, 304, 0, -282);
            thicknessAnimation1.To = new Thickness(60, 4, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textpass.BeginAnimation(MarginProperty, thicknessAnimation1);
            ////
            ThicknessAnimation thicknessAnimation52 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(155, 28, 0, 0);
            thicknessAnimation1.To = new Thickness(155, 518, 0, -473);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            ButLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation53 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(452, 24, -521, 0);
            thicknessAnimation1.To = new Thickness(-331, 24, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            ButRegist.BeginAnimation(MarginProperty, thicknessAnimation1);
            ////4
            ThicknessAnimation thicknessAnimation54 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(407, 64, -368, 0);
            thicknessAnimation1.To = new Thickness(23, 64, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextAge.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation55 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(49, -323, 0, 0);
            thicknessAnimation1.To = new Thickness(49, 29, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            LAbelAge.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation56 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-735, 25, 0, 0);
            thicknessAnimation1.To = new Thickness(12, 25, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextName.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation57 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(120, -316, 0, 0);
            thicknessAnimation1.To = new Thickness(180, 32, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            LAbelName.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation58 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-707, 47, 0, 0);
            thicknessAnimation1.To = new Thickness(0, 35, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextStatus.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation59 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-838, 23, 0, -4);
            thicknessAnimation1.To = new Thickness(42, 23, 0, -4);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            LAblstatus.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation113 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(125, 139, 0, -98);
            thicknessAnimation1.To = new Thickness(113, -41, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextidLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation114 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-624, 11, 0, 0);
            thicknessAnimation1.To = new Thickness(0, 11, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextidName.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation115 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-656, 0, 0, 0);
            thicknessAnimation1.To = new Thickness(34, -20, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textidstatus.BeginAnimation(MarginProperty, thicknessAnimation1);


            TOR = 1;
        }

        private void Redakt_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation thicknessAnimation53 = new ThicknessAnimation();
            thicknessAnimation53.From = new Thickness(115, -285, -32, 0);
            thicknessAnimation53.To = new Thickness(76, 81, 0, 0);
            thicknessAnimation53.Duration = TimeSpan.FromSeconds(1);
            textdalete.BeginAnimation(MarginProperty, thicknessAnimation53);

            DoubleAnimation opacityAnim131 = new DoubleAnimation();
            opacityAnim131.From = 1;
            opacityAnim131.To = 0.0;
            opacityAnim131.Duration = TimeSpan.FromSeconds(2);
            Add.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Delete.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Redakt.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Listinfo.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            //
            ThicknessAnimation thicknessAnimation91 = new ThicknessAnimation();
            thicknessAnimation91.From = new Thickness(87, 83, 0, 0);
            thicknessAnimation91.To = new Thickness(87, -346, 0, 0);
            thicknessAnimation91.Duration = TimeSpan.FromSeconds(1);
            Add.BeginAnimation(MarginProperty, thicknessAnimation91);
            //
            ThicknessAnimation thicknessAnimation92 = new ThicknessAnimation();
            thicknessAnimation92.From = new Thickness(87, 175, 0, 0);
            thicknessAnimation92.To = new Thickness(87, -252, 0, 0);
            thicknessAnimation92.Duration = TimeSpan.FromSeconds(1);
            Delete.BeginAnimation(MarginProperty, thicknessAnimation92);
            //
            ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
            thicknessAnimation93.From = new Thickness(0, 57, 0, 0);
            thicknessAnimation93.To = new Thickness(123, -122, 0, 0);
            thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
            Exit.BeginAnimation(MarginProperty, thicknessAnimation93);
            //
            ThicknessAnimation thicknessAnimation94 = new ThicknessAnimation();
            thicknessAnimation94.From = new Thickness(87, 132, 0, 0);
            thicknessAnimation94.To = new Thickness(87, -299, 0, 0);
            thicknessAnimation94.Duration = TimeSpan.FromSeconds(1);
            Redakt.BeginAnimation(MarginProperty, thicknessAnimation94);
            //
            ThicknessAnimation thicknessAnimation95 = new ThicknessAnimation();
            thicknessAnimation95.From = new Thickness(24, 49, 0, 0);
            thicknessAnimation95.To = new Thickness(24, -338, 0, 0);
            thicknessAnimation95.Duration = TimeSpan.FromSeconds(1);
            Listinfo.BeginAnimation(MarginProperty, thicknessAnimation95);

            TextName.Clear();
            TextLog.Clear();
            Textpass.Clear();
            DoubleAnimation opacityAnim1 = new DoubleAnimation();
            opacityAnim1.From = 1;
            opacityAnim1.To = 0.0;
            opacityAnim1.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
            //
            ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(60, 14, 0, 0);
            thicknessAnimation1.To = new Thickness(-543, 14, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(62, 4, 0, 0);
            thicknessAnimation1.To = new Thickness(311, 4, -547, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textpass.BeginAnimation(MarginProperty, thicknessAnimation2);
            //
            ////////////////////////////////
            DoubleAnimation opacityAnim2 = new DoubleAnimation();
            opacityAnim2.From = 0.0;
            opacityAnim2.To = 1;
            opacityAnim2.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAbelAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAbelName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAblstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextStatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            //TextidPass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextidLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextidName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            Textidstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            //
            ThicknessAnimation thicknessAnimation12 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(60, -358, 0, 0);
            thicknessAnimation1.To = new Thickness(60, 14, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation22 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(62, 304, 0, -282);
            thicknessAnimation1.To = new Thickness(60, 4, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textpass.BeginAnimation(MarginProperty, thicknessAnimation1);
            ////
            ThicknessAnimation thicknessAnimation52 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(155, 28, 0, 0);
            thicknessAnimation1.To = new Thickness(155, 518, 0, -473);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            ButLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation531 = new ThicknessAnimation();
            thicknessAnimation531.From = new Thickness(452, 24, -521, 0);
            thicknessAnimation531.To = new Thickness(-331, 24, 0, 0);
            thicknessAnimation531.Duration = TimeSpan.FromSeconds(1);
            ButRegist.BeginAnimation(MarginProperty, thicknessAnimation531);
            ////4
            ThicknessAnimation thicknessAnimation54 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(407, 64, -368, 0);
            thicknessAnimation1.To = new Thickness(23, 64, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextAge.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation55 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(49, -323, 0, 0);
            thicknessAnimation1.To = new Thickness(49, 29, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            LAbelAge.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation56 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-735, 25, 0, 0);
            thicknessAnimation1.To = new Thickness(12, 25, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextName.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation57 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(120, -316, 0, 0);
            thicknessAnimation1.To = new Thickness(180, 32, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            LAbelName.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation58 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-707, 47, 0, 0);
            thicknessAnimation1.To = new Thickness(0, 35, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextStatus.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation59 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-838, 23, 0, -4);
            thicknessAnimation1.To = new Thickness(42, 23, 0, -4);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            LAblstatus.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation113 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(125, 139, 0, -98);
            thicknessAnimation1.To = new Thickness(113, -41, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextidLog.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation114 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-624, 11, 0, 0);
            thicknessAnimation1.To = new Thickness(0, 11, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            TextidName.BeginAnimation(MarginProperty, thicknessAnimation1);
            //
            ThicknessAnimation thicknessAnimation115 = new ThicknessAnimation();
            thicknessAnimation1.From = new Thickness(-656, 0, 0, 0);
            thicknessAnimation1.To = new Thickness(34, -20, 0, 0);
            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
            Textidstatus.BeginAnimation(MarginProperty, thicknessAnimation1);

            if (strrrr >= 1) {
                string connectionString = @"Data Source=Server1;Initial Catalog=Hos55;User ID=student;Integrated Security=False";
                SqlConnection connection = new SqlConnection(connectionString);

                string query = $"UPDATE Passwords SET Passwords={Textpass.Password.ToString()} WHERE ID={IDID}";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                //
                query = $"UPDATE logins SET Logins={TextLog.Text} WHERE ID={IDID}";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                //
                query = $"UPDATE Uzer SET Name={TextName.Text}, age={TextAge.Text} WHERE ID={IDID}";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                //
                query = $"UPDATE Statuser SET Statuse={TextStatus.Text} WHERE ID={IDID}";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            strrrr++;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation thicknessAnimation222 = new ThicknessAnimation();
            thicknessAnimation222.From = new Thickness(76, 81, 0, 0);
            thicknessAnimation222.To = new Thickness(115, -285, -32, 0);
            thicknessAnimation222.Duration = TimeSpan.FromSeconds(1);
            textdalete.BeginAnimation(MarginProperty, thicknessAnimation222);
            DoubleAnimation opacityAnim131 = new DoubleAnimation();
            opacityAnim131.From = 1;
            opacityAnim131.To = 0.0;
            opacityAnim131.Duration = TimeSpan.FromSeconds(2);
            Add.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Delete.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Redakt.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            Listinfo.BeginAnimation(Button.OpacityProperty, opacityAnim131);
            //
            ThicknessAnimation thicknessAnimation91 = new ThicknessAnimation();
            thicknessAnimation91.From = new Thickness(87, 83, 0, 0);
            thicknessAnimation91.To = new Thickness(87, -346, 0, 0);
            thicknessAnimation91.Duration = TimeSpan.FromSeconds(1);
            Add.BeginAnimation(MarginProperty, thicknessAnimation91);
            //
            ThicknessAnimation thicknessAnimation92 = new ThicknessAnimation();
            thicknessAnimation92.From = new Thickness(87, 175, 0, 0);
            thicknessAnimation92.To = new Thickness(87, -252, 0, 0);
            thicknessAnimation92.Duration = TimeSpan.FromSeconds(1);
            Delete.BeginAnimation(MarginProperty, thicknessAnimation92);
            //
            ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
            thicknessAnimation93.From = new Thickness(0, 57, 0, 0);
            thicknessAnimation93.To = new Thickness(123, -122, 0, 0);
            thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
            Exit.BeginAnimation(MarginProperty, thicknessAnimation93);
            //
            ThicknessAnimation thicknessAnimation94 = new ThicknessAnimation();
            thicknessAnimation94.From = new Thickness(87, 132, 0, 0);
            thicknessAnimation94.To = new Thickness(87, -299, 0, 0);
            thicknessAnimation94.Duration = TimeSpan.FromSeconds(1);
            Redakt.BeginAnimation(MarginProperty, thicknessAnimation94);
            //
            ThicknessAnimation thicknessAnimation95 = new ThicknessAnimation();
            thicknessAnimation95.From = new Thickness(24, 49, 0, 0);
            thicknessAnimation95.To = new Thickness(24, -338, 0, 0);
            thicknessAnimation95.Duration = TimeSpan.FromSeconds(1);
            Listinfo.BeginAnimation(MarginProperty, thicknessAnimation95);
            TextLog.Clear();
            Textpass.Clear();
            DoubleAnimation opacityAnim2 = new DoubleAnimation();
            opacityAnim2.From = 1;
            opacityAnim2.To = 0.0;
            opacityAnim2.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAbelAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAbelName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            LAblstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextStatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            //TextidPass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextidLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            TextidName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            Textidstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
            //
            DoubleAnimation opacityAnim3 = new DoubleAnimation();
            opacityAnim3.From = 0.0;
            opacityAnim3.To = 1;
            opacityAnim3.Duration = TimeSpan.FromSeconds(2);
            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim3);
            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim3);
            ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim3);

            ThicknessAnimation thicknessAnimation12 = new ThicknessAnimation();
            thicknessAnimation12.From = new Thickness(60, -358, 0, 0);
            thicknessAnimation12.To = new Thickness(60, 14, 0, 0);
            thicknessAnimation12.Duration = TimeSpan.FromSeconds(1);
            TextLog.BeginAnimation(MarginProperty, thicknessAnimation12);
            //
            ThicknessAnimation thicknessAnimation22 = new ThicknessAnimation();
            thicknessAnimation22.From = new Thickness(62, 304, 0, -282);
            thicknessAnimation22.To = new Thickness(60, 4, 0, 0);
            thicknessAnimation22.Duration = TimeSpan.FromSeconds(1);
            Textpass.BeginAnimation(MarginProperty, thicknessAnimation22);
            ////+
            ThicknessAnimation thicknessAnimation52 = new ThicknessAnimation();
            thicknessAnimation52.From = new Thickness(155, 518, 0, -473);
            thicknessAnimation52.To = new Thickness(0, 57, 0, 0);
            thicknessAnimation52.Duration = TimeSpan.FromSeconds(1);
            ButLog.BeginAnimation(MarginProperty, thicknessAnimation52);
            //+
            ThicknessAnimation thicknessAnimation53 = new ThicknessAnimation();
            thicknessAnimation53.From = new Thickness(-331, 24, 0, 0);
            thicknessAnimation53.To = new Thickness(452, 24, -521, 0);
            thicknessAnimation53.Duration = TimeSpan.FromSeconds(1);
            ButRegist.BeginAnimation(MarginProperty, thicknessAnimation53);
            ////4+
            ThicknessAnimation thicknessAnimation54 = new ThicknessAnimation();
            thicknessAnimation54.From = new Thickness(23, 64, 0, 0);
            thicknessAnimation54.To = new Thickness(407, 64, -368, 0);
            thicknessAnimation54.Duration = TimeSpan.FromSeconds(1);
            TextAge.BeginAnimation(MarginProperty, thicknessAnimation54);
            //+
            ThicknessAnimation thicknessAnimation55 = new ThicknessAnimation();
            thicknessAnimation55.From = new Thickness(49, 29, 0, 0);
            thicknessAnimation55.To = new Thickness(49, -323, 0, 0);
            thicknessAnimation55.Duration = TimeSpan.FromSeconds(1);
            LAbelAge.BeginAnimation(MarginProperty, thicknessAnimation55);
            //+
            ThicknessAnimation thicknessAnimation56 = new ThicknessAnimation();
            thicknessAnimation56.From = new Thickness(12, 25, 0, 0);
            thicknessAnimation56.To = new Thickness(-735, 25, 0, 0);
            thicknessAnimation56.Duration = TimeSpan.FromSeconds(1);
            TextName.BeginAnimation(MarginProperty, thicknessAnimation56);
            //+
            ThicknessAnimation thicknessAnimation57 = new ThicknessAnimation();
            thicknessAnimation57.From = new Thickness(180, 32, 0, 0);
            thicknessAnimation57.To = new Thickness(120, -316, 0, 0);
            thicknessAnimation57.Duration = TimeSpan.FromSeconds(1);
            LAbelName.BeginAnimation(MarginProperty, thicknessAnimation57);
            //+
            ThicknessAnimation thicknessAnimation58 = new ThicknessAnimation();
            thicknessAnimation58.From = new Thickness(0, 35, 0, 0);
            thicknessAnimation58.To = new Thickness(-707, 47, 0, 0);
            thicknessAnimation58.Duration = TimeSpan.FromSeconds(1);
            TextStatus.BeginAnimation(MarginProperty, thicknessAnimation58);
            //+
            ThicknessAnimation thicknessAnimation59 = new ThicknessAnimation();
            thicknessAnimation59.From = new Thickness(42, 23, 0, -4);
            thicknessAnimation59.To = new Thickness(-838, 23, 0, -4);
            thicknessAnimation59.Duration = TimeSpan.FromSeconds(1);
            LAblstatus.BeginAnimation(MarginProperty, thicknessAnimation59);
            //+
            ThicknessAnimation thicknessAnimation113 = new ThicknessAnimation();
            thicknessAnimation113.From = new Thickness(113, -41, 0, 0);
            thicknessAnimation113.To = new Thickness(125, 139, 0, -98);
            thicknessAnimation113.Duration = TimeSpan.FromSeconds(1);
            TextidLog.BeginAnimation(MarginProperty, thicknessAnimation113);
            //+
            ThicknessAnimation thicknessAnimation114 = new ThicknessAnimation();
            thicknessAnimation114.From = new Thickness(0, 11, 0, 0);
            thicknessAnimation114.To = new Thickness(-624, 11, 0, 0);
            thicknessAnimation114.Duration = TimeSpan.FromSeconds(1);
            TextidName.BeginAnimation(MarginProperty, thicknessAnimation114);
            //+
            ThicknessAnimation thicknessAnimation115 = new ThicknessAnimation();
            thicknessAnimation115.From = new Thickness(34, -20, 0, 0);
            thicknessAnimation115.To = new Thickness(-656, 0, 0, 0);
            thicknessAnimation115.Duration = TimeSpan.FromSeconds(1);
            Textidstatus.BeginAnimation(MarginProperty, thicknessAnimation115);

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {//115,-285,-32,0
            ThicknessAnimation thicknessAnimation53 = new ThicknessAnimation();
            thicknessAnimation53.From = new Thickness(115, -285, -32, 0);
            thicknessAnimation53.To = new Thickness(76, 81, 0, 0);
            thicknessAnimation53.Duration = TimeSpan.FromSeconds(1);
            textdalete.BeginAnimation(MarginProperty, thicknessAnimation53);
            
            if (ttr >= 1)
            {
                string connectionString = @"Data Source=Server1;Initial Catalog=Hos55;User ID=student;Integrated Security=False";
                SqlConnection connection = new SqlConnection(connectionString);
                string queryss = $"DELETE Passwords;WHERE Id ={textdalete.Text};";
                SqlCommand cmd = new SqlCommand(queryss, connection);
                cmd.ExecuteNonQuery();
                queryss = $"DELETE logins;WHERE Id ={textdalete.Text};";
                cmd = new SqlCommand(queryss, connection);
                cmd.ExecuteNonQuery();
                queryss = $"DELETE Uzer;WHERE Id ={textdalete.Text};";
                cmd = new SqlCommand(queryss, connection);
                cmd.ExecuteNonQuery();
                queryss = $"DELETE Statuser;WHERE Id ={textdalete.Text};";
                cmd = new SqlCommand(queryss, connection);
                cmd.ExecuteNonQuery();
            }
            ttr++;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
   
        }

        private bool IsLegalQuery(string strText)
        {
            //bool islegal = false;
            if (strText.Length > 0)
            {
                string[] legalcharsStr = new string[] {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н","О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш","Щ","Э","Ы","Ъ","Ь","Ю","Я","а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","э","ъ","ь","ы","ю","я","0","1","2","3","4","5","6","7","8","9","0"}; 
                islegal = true;
                char[] legalchars= new char[128];
                for(int i=0;i<128;i++)
                {
                    legalchars[i] = Convert.ToChar(legalcharsStr[i]);
                }
                foreach (var item in strText)
                {
                    if (!legalchars.Contains(item))
                    {

                        islegal = false;
                        MessageBox.Show("Ведены запрещеные символы!");
                        break;

                    }
                }
          
                MessageBox.Show(islegal.ToString());

            }
            return islegal;
         
        }

        private void TextName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAge_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private bool ConnectionOpens()
        {
            string connectionString = @"Data Source=Server1;Initial Catalog=Hos55;User ID=student;Integrated Security=False";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                return true;

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Невозможно подключиться к серверу.Свяжитесь с администратором");
                        break;

                    case 1045:
                        MessageBox.Show("Неверное имя пользователя / пароль, пожалуйста, повторрите ввод еще раз");
                        break;
                }
                return false;
            }

        }
        private bool CloseConnection()
        {
            string connectionString = @"Data Source=Server1;Initial Catalog=Hos55;User ID=student;Integrated Security=False";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void ButRegist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string connectionString = @"Data Source=Server1;Initial Catalog=Hos55;User ID=student;Integrated Security=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Name =Convert.ToString(TextName.Text);
                Age = Convert.ToString(TextAge.Text);
                paswordeses = Convert.ToString(Textpass.Password);
                Logineses= Convert.ToString(TextLog.Text);
                sTATUS = Convert.ToString(TextStatus.Text);
                idlog = Convert.ToString(TextidLog.Text);
              //  idpass = Convert.ToString(TextidPass.Text);
                idstatus = Convert.ToString(Textidstatus.Text);
                idname = Convert.ToString(TextidName.Text);
                if (idididid >= 4)
                {
                    TextLog.Clear();
                    Textpass.Clear();
                    DoubleAnimation opacityAnim2 = new DoubleAnimation();
                    opacityAnim2.From = 1;
                    opacityAnim2.To = 0.0;
                    opacityAnim2.Duration = TimeSpan.FromSeconds(2);
                    TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    LAbelAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    LAbelName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    LAblstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextStatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    //TextidPass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextidLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextidName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    Textidstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    //
                    DoubleAnimation opacityAnim3 = new DoubleAnimation();
                    opacityAnim3.From = 0.0;
                    opacityAnim3.To = 1;
                    opacityAnim3.Duration = TimeSpan.FromSeconds(2);
                    TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim3);
                    Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim3);
                    ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim3);

                    ThicknessAnimation thicknessAnimation12 = new ThicknessAnimation();
                    thicknessAnimation12.From = new Thickness(60, -358, 0, 0);
                    thicknessAnimation12.To = new Thickness(60, 14, 0, 0);
                    thicknessAnimation12.Duration = TimeSpan.FromSeconds(1);
                    TextLog.BeginAnimation(MarginProperty, thicknessAnimation12);
                    //
                    ThicknessAnimation thicknessAnimation22 = new ThicknessAnimation();
                    thicknessAnimation22.From = new Thickness(62, 304, 0, -282);
                    thicknessAnimation22.To = new Thickness(60, 4, 0, 0);
                    thicknessAnimation22.Duration = TimeSpan.FromSeconds(1);
                    Textpass.BeginAnimation(MarginProperty, thicknessAnimation22);
                    ////+
                    ThicknessAnimation thicknessAnimation52 = new ThicknessAnimation();
                    thicknessAnimation52.From = new Thickness(155, 518, 0, -473);
                    thicknessAnimation52.To = new Thickness(0, 57, 0, 0);
                    thicknessAnimation52.Duration = TimeSpan.FromSeconds(1);
                    ButLog.BeginAnimation(MarginProperty, thicknessAnimation52);
                    //+
                    ThicknessAnimation thicknessAnimation53 = new ThicknessAnimation();
                    thicknessAnimation53.From = new Thickness(-331, 24, 0, 0);
                    thicknessAnimation53.To = new Thickness(452, 24, -521, 0);
                    thicknessAnimation53.Duration = TimeSpan.FromSeconds(1);
                    ButRegist.BeginAnimation(MarginProperty, thicknessAnimation53);
                    ////4+
                    ThicknessAnimation thicknessAnimation54 = new ThicknessAnimation();
                    thicknessAnimation54.From = new Thickness(23, 64, 0, 0);
                    thicknessAnimation54.To = new Thickness(407, 64, -368, 0);
                    thicknessAnimation54.Duration = TimeSpan.FromSeconds(1);
                    TextAge.BeginAnimation(MarginProperty, thicknessAnimation54);
                    //+
                    ThicknessAnimation thicknessAnimation55 = new ThicknessAnimation();
                    thicknessAnimation55.From = new Thickness(49, 29, 0, 0);
                    thicknessAnimation55.To = new Thickness(49, -323, 0, 0);
                    thicknessAnimation55.Duration = TimeSpan.FromSeconds(1);
                    LAbelAge.BeginAnimation(MarginProperty, thicknessAnimation55);
                    //+
                    ThicknessAnimation thicknessAnimation56 = new ThicknessAnimation();
                    thicknessAnimation56.From = new Thickness(12, 25, 0, 0);
                    thicknessAnimation56.To = new Thickness(-735, 25, 0, 0);
                    thicknessAnimation56.Duration = TimeSpan.FromSeconds(1);
                    TextName.BeginAnimation(MarginProperty, thicknessAnimation56);
                    //+
                    ThicknessAnimation thicknessAnimation57 = new ThicknessAnimation();
                    thicknessAnimation57.From = new Thickness(180, 32, 0, 0);
                    thicknessAnimation57.To = new Thickness(120, -316, 0, 0);
                    thicknessAnimation57.Duration = TimeSpan.FromSeconds(1);
                    LAbelName.BeginAnimation(MarginProperty, thicknessAnimation57);
                    //+
                    ThicknessAnimation thicknessAnimation58 = new ThicknessAnimation();
                    thicknessAnimation58.From = new Thickness(0, 35, 0, 0);
                    thicknessAnimation58.To = new Thickness(-707, 47, 0, 0);
                    thicknessAnimation58.Duration = TimeSpan.FromSeconds(1);
                    TextStatus.BeginAnimation(MarginProperty, thicknessAnimation58);
                    //+
                    ThicknessAnimation thicknessAnimation59 = new ThicknessAnimation();
                    thicknessAnimation59.From = new Thickness(42, 23, 0, -4);
                    thicknessAnimation59.To = new Thickness(-838, 23, 0, -4);
                    thicknessAnimation59.Duration = TimeSpan.FromSeconds(1);
                    LAblstatus.BeginAnimation(MarginProperty, thicknessAnimation59);
                    //+
                    ThicknessAnimation thicknessAnimation113 = new ThicknessAnimation();
                    thicknessAnimation113.From = new Thickness(113, -41, 0, 0);
                    thicknessAnimation113.To = new Thickness(125, 139, 0, -98);
                    thicknessAnimation113.Duration = TimeSpan.FromSeconds(1);
                    TextidLog.BeginAnimation(MarginProperty, thicknessAnimation113);
                    //+
                    ThicknessAnimation thicknessAnimation114 = new ThicknessAnimation();
                    thicknessAnimation114.From = new Thickness(0, 11, 0, 0);
                    thicknessAnimation114.To = new Thickness(-624, 11, 0, 0);
                    thicknessAnimation114.Duration = TimeSpan.FromSeconds(1);
                    TextidName.BeginAnimation(MarginProperty, thicknessAnimation114);
                    //+
                    ThicknessAnimation thicknessAnimation115 = new ThicknessAnimation();
                    thicknessAnimation115.From = new Thickness(34, -20, 0, 0);
                    thicknessAnimation115.To = new Thickness(-656, 0, 0, 0);
                    thicknessAnimation115.Duration = TimeSpan.FromSeconds(1);
                    Textidstatus.BeginAnimation(MarginProperty, thicknessAnimation115);
                    //

                     if(TOR==1)
                    {
                        //
                        TextName.Clear();
                        TextLog.Clear();
                        Textpass.Clear();
                        DoubleAnimation opacityAnim1 = new DoubleAnimation();
                        opacityAnim1.From = 1;
                        opacityAnim1.To = 0.0;
                        opacityAnim1.Duration = TimeSpan.FromSeconds(2);
                        TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                        Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                        ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                        //
                        ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                        thicknessAnimation1.From = new Thickness(60, 14, 0, 0);
                        thicknessAnimation1.To = new Thickness(-543, 14, 0, 0);
                        thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                        TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                        //
                        ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                        thicknessAnimation1.From = new Thickness(62, 4, 0, 0);
                        thicknessAnimation1.To = new Thickness(311, 4, -547, 0);
                        thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                        Textpass.BeginAnimation(MarginProperty, thicknessAnimation2);
                        //
                        ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
                        thicknessAnimation1.From = new Thickness(155, 518, 0, -473);
                        thicknessAnimation1.To = new Thickness(155, 28, 0, 0);
                        thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                        ButLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                        //
                        DoubleAnimation opacityAnim131 = new DoubleAnimation();
                        opacityAnim131.From = 0.0;
                        opacityAnim131.To = 1;
                        opacityAnim131.Duration = TimeSpan.FromSeconds(2);
                        Add.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                        Delete.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                        Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                        Redakt.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                        Listinfo.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                        //
                        ThicknessAnimation thicknessAnimation91 = new ThicknessAnimation();
                        thicknessAnimation91.From = new Thickness(87, -346, 0, 0);
                        thicknessAnimation91.To = new Thickness(87, 83, 0, 0);
                        thicknessAnimation91.Duration = TimeSpan.FromSeconds(1);
                        Add.BeginAnimation(MarginProperty, thicknessAnimation91);
                        //
                        ThicknessAnimation thicknessAnimation92 = new ThicknessAnimation();
                        thicknessAnimation92.From = new Thickness(87, -252, 0, 0);
                        thicknessAnimation92.To = new Thickness(87, 175, 0, 0);
                        thicknessAnimation92.Duration = TimeSpan.FromSeconds(1);
                        Delete.BeginAnimation(MarginProperty, thicknessAnimation92);
                        //
                        ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
                        thicknessAnimation93.From = new Thickness(123, -122, 0, 0);
                        thicknessAnimation93.To = new Thickness(0, 57, 0, 0);
                        thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
                        Exit.BeginAnimation(MarginProperty, thicknessAnimation93);
                        //
                        ThicknessAnimation thicknessAnimation94 = new ThicknessAnimation();
                        thicknessAnimation94.From = new Thickness(87, -299, 0, 0);
                        thicknessAnimation94.To = new Thickness(87, 132, 0, 0);
                        thicknessAnimation94.Duration = TimeSpan.FromSeconds(1);
                        Redakt.BeginAnimation(MarginProperty, thicknessAnimation94);
                        //
                        ThicknessAnimation thicknessAnimation95 = new ThicknessAnimation();
                        thicknessAnimation95.From = new Thickness(24, -338, 0, 0);
                        thicknessAnimation95.To = new Thickness(24, 49, 0, 0);
                        thicknessAnimation95.Duration = TimeSpan.FromSeconds(1);
                        Listinfo.BeginAnimation(MarginProperty, thicknessAnimation95);
                    }
                }
                else
                {
                    IsLegalQuery(paswordeses);
                    if (islegal == true)
                    {
                        string queryss = $"INSERT INTO [Passwords] VALUES(@Password);";
                        // if (this.ConnectionOpens() == true)
                        // {
                        SqlCommand cmd = new SqlCommand(queryss, connection);
                        cmd.Parameters.Add(new SqlParameter("@Password", Textpass.Password));
                        //   cmd.Parameters.Add(new SqlParameter("@idPassword", TextidPass.Text.ToString()));
                        cmd.ExecuteNonQuery();
                        //     this.CloseConnection();
                        // }
                        idididid ++;
                    }
                    //
                    IsLegalQuery(idlog);
                    IsLegalQuery(Logineses);
                    if (islegal == true)
                    {
                        string querys = $"INSERT INTO [logins] VALUES(@login,@idlogin);";
                        // if (this.ConnectionOpens() == true)
                        //  {
                        SqlCommand cmd = new SqlCommand(querys, connection);
                        cmd.Parameters.Add(new SqlParameter("@login", TextLog.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@idlogin", TextidLog.Text.ToString()));
                        cmd.ExecuteNonQuery();
                        //    this.CloseConnection();
                        // }
                        idididid++;
                    }
                    //
                    IsLegalQuery(idname);
                    IsLegalQuery(Name);
                    IsLegalQuery(Age);
                    if (islegal == true)
                    {
                        string query = $"INSERT INTO [Uzer] VALUES(@Name,@AGE,@iduser);";
                        // if (this.ConnectionOpens() == true)
                        //  {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add(new SqlParameter("@Name", TextName.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@AGE", TextAge.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@iduser", TextidName.Text.ToString()));
                        cmd.ExecuteNonQuery();
                        //   this.CloseConnection();
                        // }
                        idididid++;
                    }
                    //
                    IsLegalQuery(idstatus);
                    IsLegalQuery(sTATUS);
                    if (islegal == true)
                    {
                        string querye = $"INSERT INTO [Statuser] VALUES(@Status,@idStatus);";
                        // if (this.ConnectionOpens() == true)
                        //  {
                        SqlCommand cmd = new SqlCommand(querye, connection);
                        cmd.Parameters.Add(new SqlParameter("@Status", TextStatus.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@idStatus", Textidstatus.Text.ToString()));
                        cmd.ExecuteNonQuery();
                        //   this.CloseConnection();
                        // }
                        idididid++;
                    }

                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Login = Convert.ToString(TextLog);
            // IsLegalQuery(Login);
            if (Horses == 4)
            {
                MessageBox.Show("Привышен лимит входа. Пройдите регистрацыю в Системе!");
                if (Hor1 == 0)
                {
                    TextName.Clear();
                    TextLog.Clear();
                    Textpass.Clear();
                    DoubleAnimation opacityAnim1 = new DoubleAnimation();
                    opacityAnim1.From = 1;
                    opacityAnim1.To = 0.0;
                    opacityAnim1.Duration = TimeSpan.FromSeconds(2);
                    TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                    Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                    ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                    //
                    ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(60, 14, 0, 0);
                    thicknessAnimation1.To = new Thickness (-543, 14, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(62, 4, 0, 0);
                    thicknessAnimation1.To = new Thickness (311, 4, -547, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    Textpass.BeginAnimation(MarginProperty, thicknessAnimation2);
                    //
                    ////////////////////////////////
                    DoubleAnimation opacityAnim2 = new DoubleAnimation();
                    opacityAnim2.From =0.0;
                    opacityAnim2.To = 1;
                    opacityAnim2.Duration = TimeSpan.FromSeconds(2);
                    TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    LAbelAge.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    LAbelName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    LAblstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextStatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    //TextidPass.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextidLog.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    TextidName.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    Textidstatus.BeginAnimation(Button.OpacityProperty, opacityAnim2);
                    //
                    ThicknessAnimation thicknessAnimation12 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(60,-358,0,0);
                    thicknessAnimation1.To = new Thickness(60, 14, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation22 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(62, 304, 0, -282);
                    thicknessAnimation1.To = new Thickness(60, 4, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    Textpass.BeginAnimation(MarginProperty, thicknessAnimation1);
                    ////
                    ThicknessAnimation thicknessAnimation52 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(155, 28, 0, 0);
                    thicknessAnimation1.To = new Thickness(155, 518, 0, -473);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    ButLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation53 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(452, 24, -521, 0);
                    thicknessAnimation1.To = new Thickness(-331, 24, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    ButRegist.BeginAnimation(MarginProperty, thicknessAnimation1);
                    ////4
                    ThicknessAnimation thicknessAnimation54 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(407, 64, -368, 0);
                    thicknessAnimation1.To = new Thickness(23, 64, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextAge.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation55 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(49, -323, 0, 0);
                    thicknessAnimation1.To = new Thickness(49, 29, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    LAbelAge.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation56 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(-735, 25, 0, 0);
                    thicknessAnimation1.To = new Thickness(12, 25, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextName.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation57 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(120, -316, 0, 0);
                    thicknessAnimation1.To = new Thickness(180, 32, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    LAbelName.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation58 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(-707, 47, 0, 0);
                    thicknessAnimation1.To = new Thickness(0, 35, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextStatus.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation59 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(-838, 23, 0, -4);
                    thicknessAnimation1.To = new Thickness(42, 23, 0, -4);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    LAblstatus.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation113 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(125, 139, 0, -98);
                    thicknessAnimation1.To = new Thickness(113, -41, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextidLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation114 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(-624, 11, 0, 0);
                    thicknessAnimation1.To = new Thickness(0, 11, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    TextidName.BeginAnimation(MarginProperty, thicknessAnimation1);
                    //
                    ThicknessAnimation thicknessAnimation115 = new ThicknessAnimation();
                    thicknessAnimation1.From = new Thickness(-656,0,0,0);
                    thicknessAnimation1.To = new Thickness(34, -20, 0, 0);
                    thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                    Textidstatus.BeginAnimation(MarginProperty, thicknessAnimation1);
                    Hor1 = 1;
                }
            }
            else
            {

                try
                {

                    string connectionString = @"Data Source=Server1;Initial Catalog=Hos55;User ID=student;Integrated Security=False";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    Login = Convert.ToString(TextLog);
                    Passwords = Convert.ToString(Textpass);
                   
                    IsLegalQuery(TextLog.Text);
                    IsLegalQuery(Textpass.Password);
                    if (islegal == true)
                    {
                       
                        SqlCommand commandss = new SqlCommand("SELECT [ID],[Logins], [Passwords],[Statuse] FROM logins INNER JOIN Passwords ON logins.ID_password=Passwords.ID INNER JOIN Uzer ON logins.ID_password=Uzer.ID INNER JOIN Statuser ON logins.ID_password=Statuser.ID", connection);
                        SqlDataReader readerss = commandss.ExecuteReader();
                        while (readerss.Read())
                        {
                            for (int i = 1; i < readerss.FieldCount; i++)
                            {
                                IDID= Convert.ToString(readerss[i]);
                                LoginDB = Convert.ToString(readerss[i+1]);
                                if (LoginDB==TextLog.Text)
                                {
                                    PasswordsDB = Convert.ToString(readerss[i+2]);
                                    if(PasswordsDB==Textpass.Password.ToString())
                                    {
                                        status= Convert.ToString(readerss[i + 3]);
                                        string[] countries = { IDID,LoginDB,PasswordsDB,status};
                                        Listinfo.Items.Add(countries);
                                    }
                                }
                            
                            }
                            //Listinfo =@"->"{LoginDB}"  ->"{PasswordsDB }"->"{ status}"";
                        }
                        readerss.Close();
                        if (TextLog.Text == LoginDB && Textpass.ToString() == PasswordsDB)
                        {
                            MessageBox.Show("Подключение было выполнено. Добро пожаловать");
                            TextName.Clear();
                            TextLog.Clear();
                            Textpass.Clear();
                            DoubleAnimation opacityAnim1 = new DoubleAnimation();
                            opacityAnim1.From = 1;
                            opacityAnim1.To = 0.0;
                            opacityAnim1.Duration = TimeSpan.FromSeconds(2);
                            TextLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                            Textpass.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                            ButLog.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                            //
                            ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                            thicknessAnimation1.From = new Thickness(60, 14, 0, 0);
                            thicknessAnimation1.To = new Thickness(-543, 14, 0, 0);
                            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                            TextLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                            //
                            ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                            thicknessAnimation1.From = new Thickness(62, 4, 0, 0);
                            thicknessAnimation1.To = new Thickness(311, 4, -547, 0);
                            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                            Textpass.BeginAnimation(MarginProperty, thicknessAnimation2);
                            //
                            ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
                            thicknessAnimation1.From = new Thickness(155, 518, 0, -473);
                            thicknessAnimation1.To = new Thickness(155, 28, 0, 0);
                            thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                            ButLog.BeginAnimation(MarginProperty, thicknessAnimation1);
                            //

                            if (status=="Admin")
                            {
                             DoubleAnimation opacityAnim131 = new DoubleAnimation();
                                opacityAnim131.From = 0.0;
                                opacityAnim131.To = 1;
                                opacityAnim131.Duration = TimeSpan.FromSeconds(2);
                            Add.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                            Delete.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                            Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                            Redakt.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                            Listinfo.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                                //
                            ThicknessAnimation thicknessAnimation91 = new ThicknessAnimation();
                                thicknessAnimation91.From = new Thickness(87, -346, 0, 0);
                                thicknessAnimation91.To = new Thickness(87, 83, 0, 0);
                                thicknessAnimation91.Duration = TimeSpan.FromSeconds(1);
                            Add.BeginAnimation(MarginProperty, thicknessAnimation91);
                            //
                            ThicknessAnimation thicknessAnimation92 = new ThicknessAnimation();
                                thicknessAnimation92.From = new Thickness(87, -252, 0, 0);
                                thicknessAnimation92.To = new Thickness(87, 175, 0, 0);
                                thicknessAnimation92.Duration = TimeSpan.FromSeconds(1);
                                Delete.BeginAnimation(MarginProperty, thicknessAnimation92);
                            //
                            ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
                                thicknessAnimation93.From = new Thickness(123, -122, 0, 0);
                                thicknessAnimation93.To = new Thickness(0, 57, 0, 0);
                                thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
                                Exit.BeginAnimation(MarginProperty, thicknessAnimation93);    
                                //
                                ThicknessAnimation thicknessAnimation94 = new ThicknessAnimation();
                                thicknessAnimation94.From = new Thickness(87, -299, 0, 0);
                                thicknessAnimation94.To = new Thickness(87, 132, 0, 0);
                                thicknessAnimation94.Duration = TimeSpan.FromSeconds(1);
                                Redakt.BeginAnimation(MarginProperty, thicknessAnimation94);
                                //
                                ThicknessAnimation thicknessAnimation95 = new ThicknessAnimation();
                                thicknessAnimation95.From = new Thickness(24, -338, 0, 0);
                                thicknessAnimation95.To = new Thickness(24, 49, 0, 0);
                                thicknessAnimation95.Duration = TimeSpan.FromSeconds(1);
                                Listinfo.BeginAnimation(MarginProperty, thicknessAnimation95);
                            }
                            if(status=="User")
                            {
                                DoubleAnimation opacityAnim131 = new DoubleAnimation();
                                opacityAnim131.From = 0.0;
                                opacityAnim131.To = 1;
                                opacityAnim131.Duration = TimeSpan.FromSeconds(2);
                                Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                                //
                                ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
                                thicknessAnimation93.From = new Thickness(123, -122, 0, 0);
                                thicknessAnimation93.To = new Thickness(0, 57, 0, 0);
                                thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
                                Exit.BeginAnimation(MarginProperty, thicknessAnimation93);
                            }
                            if(status=="Tester")
                            {
                                DoubleAnimation opacityAnim131 = new DoubleAnimation();
                                opacityAnim131.From = 0.0;
                                opacityAnim131.To = 1;
                                opacityAnim131.Duration = TimeSpan.FromSeconds(2);
                                Exit.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                                Listinfo.BeginAnimation(Button.OpacityProperty, opacityAnim131);
                                //
                                ThicknessAnimation thicknessAnimation93 = new ThicknessAnimation();
                                thicknessAnimation93.From = new Thickness(123, -122, 0, 0);
                                thicknessAnimation93.To = new Thickness(0, 57, 0, 0);
                                thicknessAnimation93.Duration = TimeSpan.FromSeconds(1);
                                Exit.BeginAnimation(MarginProperty, thicknessAnimation93);
                                //
                                ThicknessAnimation thicknessAnimation95 = new ThicknessAnimation();
                                thicknessAnimation95.From = new Thickness(24, -338, 0, 0);
                                thicknessAnimation95.To = new Thickness(24, 49, 0, 0);
                                thicknessAnimation95.Duration = TimeSpan.FromSeconds(1);
                                Listinfo.BeginAnimation(MarginProperty, thicknessAnimation95);
                            }

                        }
                        else
                        {
                            Horses += 1;
                            MessageBox.Show("Ошибка в попытке подключениея! Проверьте вводимые данные");
                            TOR = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные символы!");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
           
        }
    }
}
