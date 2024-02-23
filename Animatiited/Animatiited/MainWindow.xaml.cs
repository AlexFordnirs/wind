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
using System.Windows.Media.Animation;

namespace Animatiited
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
            
        }
        int f = 0;int ff = 0;
            private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0)
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 0;
                animation.To = 150;
                animation.Duration = TimeSpan.FromSeconds(2);
                PanUp.BeginAnimation(Button.HeightProperty, animation);
                f = 1;
                ////
                DoubleAnimation opacityAnim = new DoubleAnimation();
                opacityAnim.From = 0.0;
                opacityAnim.To = 1;
                opacityAnim.Duration = TimeSpan.FromSeconds(3);
                PanUp.BeginAnimation(Button.OpacityProperty, opacityAnim);
                DoubleAnimation opacityAnim1 = new DoubleAnimation();
                opacityAnim1.From = 0.0;
                opacityAnim1.To = 1;
                opacityAnim1.Duration = TimeSpan.FromSeconds(4);
                PanUp1.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp2.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp3.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp4.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp5.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp6.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp7.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp8.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp9.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                ////
                ////
                ////
                ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                thicknessAnimation1.From = new Thickness(274,-274,0,0) ;
                thicknessAnimation1.To = new Thickness(274, 21, 0, 0);
                thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                PanUp1.BeginAnimation(MarginProperty, thicknessAnimation1);
                //
                ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                thicknessAnimation2.From = new Thickness(372, -372, 0, 0);
                thicknessAnimation2.To = new Thickness(372, 21, 0, 0);
                thicknessAnimation2.Duration = TimeSpan.FromSeconds(1);
                PanUp2.BeginAnimation(MarginProperty, thicknessAnimation2);
                //
                ThicknessAnimation thicknessAnimation3 = new ThicknessAnimation();
                thicknessAnimation3.From = new Thickness(475, -475, 0, 0);
                thicknessAnimation3.To = new Thickness(475, 21, 0, 0);
                thicknessAnimation3.Duration = TimeSpan.FromSeconds(1);
                PanUp3.BeginAnimation(MarginProperty, thicknessAnimation3);
                //
                ThicknessAnimation thicknessAnimation4 = new ThicknessAnimation();
                thicknessAnimation4.From = new Thickness(274, -274, 0, 0);
                thicknessAnimation4.To = new Thickness(274, 69, 0, 0);
                thicknessAnimation4.Duration = TimeSpan.FromSeconds(2);
                PanUp4.BeginAnimation(MarginProperty, thicknessAnimation4);
                //
                ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
                thicknessAnimation5.From = new Thickness(372, -372, 0, 0);
                thicknessAnimation5.To = new Thickness(372, 69, 0, 0);
                thicknessAnimation5.Duration = TimeSpan.FromSeconds(2);
                PanUp5.BeginAnimation(MarginProperty, thicknessAnimation5);
                //
                ThicknessAnimation thicknessAnimation6 = new ThicknessAnimation();
                thicknessAnimation6.From = new Thickness(475, -475, 0, 0);
                thicknessAnimation6.To = new Thickness(475, 69, 0, 0);
                thicknessAnimation6.Duration = TimeSpan.FromSeconds(2);
                PanUp6.BeginAnimation(MarginProperty, thicknessAnimation6);
                //
                ThicknessAnimation thicknessAnimation7 = new ThicknessAnimation();
                thicknessAnimation7.From = new Thickness(274, -274, 0, 0);
                thicknessAnimation7.To = new Thickness(274, 114, 0, 0);
                thicknessAnimation7.Duration = TimeSpan.FromSeconds(3);
                PanUp7.BeginAnimation(MarginProperty, thicknessAnimation7);
                //
                ThicknessAnimation thicknessAnimation8 = new ThicknessAnimation();
                thicknessAnimation8.From = new Thickness(372, -372, 0, 0);
                thicknessAnimation8.To = new Thickness(372, 114, 0, 0);
                thicknessAnimation8.Duration = TimeSpan.FromSeconds(3);
                PanUp8.BeginAnimation(MarginProperty, thicknessAnimation8);
                //
                ThicknessAnimation thicknessAnimation9 = new ThicknessAnimation();
                thicknessAnimation9.From = new Thickness(475, -475, 0, 0);
                thicknessAnimation9.To = new Thickness(475, 114, 0, 0);
                thicknessAnimation9.Duration = TimeSpan.FromSeconds(3);
                PanUp9.BeginAnimation(MarginProperty, thicknessAnimation9);
                //

            }
            else if (f == 1)
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 150;
                animation.To = 0;
                animation.Duration = TimeSpan.FromSeconds(2);
                PanUp.BeginAnimation(Button.HeightProperty, animation);
                f = 0;
                ////
                DoubleAnimation opacityAnim = new DoubleAnimation();
                opacityAnim.From = 1;
                opacityAnim.To = 0.0;
                opacityAnim.Duration = TimeSpan.FromSeconds(3);
                PanUp.BeginAnimation(Button.OpacityProperty, opacityAnim);
                DoubleAnimation opacityAnim1 = new DoubleAnimation();
                opacityAnim1.From = 1;
                opacityAnim1.To = 0.0;
                opacityAnim1.Duration = TimeSpan.FromSeconds(2);
                PanUp1.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp2.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp3.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp4.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp5.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp6.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp7.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp8.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanUp9.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                ////
                ////
                ////
                ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                thicknessAnimation1.From = new Thickness(274, 21, 0, 0);
                thicknessAnimation1.To = new Thickness(274, -274, 0, 0);
                thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                PanUp1.BeginAnimation(MarginProperty, thicknessAnimation1);
                //
                ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                thicknessAnimation2.From = new Thickness(372, 21, 0, 0);
                thicknessAnimation2.To = new Thickness(372, -372, 0, 0);
                thicknessAnimation2.Duration = TimeSpan.FromSeconds(1);
                PanUp2.BeginAnimation(MarginProperty, thicknessAnimation2);
                //
                ThicknessAnimation thicknessAnimation3 = new ThicknessAnimation();
                thicknessAnimation3.From = new Thickness(475, 21, 0, 0);
                thicknessAnimation3.To = new Thickness(475, -475, 0, 0);
                thicknessAnimation3.Duration = TimeSpan.FromSeconds(1);
                PanUp3.BeginAnimation(MarginProperty, thicknessAnimation3);
                //
                ThicknessAnimation thicknessAnimation4 = new ThicknessAnimation();
                thicknessAnimation4.From = new Thickness(274, 69, 0, 0);
                thicknessAnimation4.To = new Thickness(274, -274, 0, 0);
                thicknessAnimation4.Duration = TimeSpan.FromSeconds(2);
                PanUp4.BeginAnimation(MarginProperty, thicknessAnimation4);
                //
                ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
                thicknessAnimation5.From = new Thickness(372, 69, 0, 0);
                thicknessAnimation5.To = new Thickness(372, -372, 0, 0);
                thicknessAnimation5.Duration = TimeSpan.FromSeconds(2);
                PanUp5.BeginAnimation(MarginProperty, thicknessAnimation5);
                //
                ThicknessAnimation thicknessAnimation6 = new ThicknessAnimation();
                thicknessAnimation6.From = new Thickness(475, 69, 0, 0);
                thicknessAnimation6.To = new Thickness(475, -475, 0, 0);
                thicknessAnimation6.Duration = TimeSpan.FromSeconds(2);
                PanUp6.BeginAnimation(MarginProperty, thicknessAnimation6);
                //
                ThicknessAnimation thicknessAnimation7 = new ThicknessAnimation();
                thicknessAnimation7.From = new Thickness(274, 114, 0, 0);
                thicknessAnimation7.To = new Thickness(274, -274, 0, 0);
                thicknessAnimation7.Duration = TimeSpan.FromSeconds(3);
                PanUp7.BeginAnimation(MarginProperty, thicknessAnimation7);
                //
                ThicknessAnimation thicknessAnimation8 = new ThicknessAnimation();
                thicknessAnimation8.From = new Thickness(372, 114, 0, 0);
                thicknessAnimation8.To = new Thickness(372, -372, 0, 0);
                thicknessAnimation8.Duration = TimeSpan.FromSeconds(3);
                PanUp8.BeginAnimation(MarginProperty, thicknessAnimation8);
                //
                ThicknessAnimation thicknessAnimation9 = new ThicknessAnimation();
                thicknessAnimation9.From = new Thickness(475, 114, 0, 0);
                thicknessAnimation9.To = new Thickness(475, -475, 0, 0);
                thicknessAnimation9.Duration = TimeSpan.FromSeconds(3);
                PanUp9.BeginAnimation(MarginProperty, thicknessAnimation9);
                //
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ff == 0)
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 0;
                animation.To = 200;
                animation.Duration = TimeSpan.FromSeconds(2);
                PanLeft.BeginAnimation(Button.WidthProperty, animation);
                ff = 1;
                ////
                DoubleAnimation opacityAnim = new DoubleAnimation();
                opacityAnim.From = 0.0;
                opacityAnim.To = 1;
                opacityAnim.Duration = TimeSpan.FromSeconds(3);
                PanLeft.BeginAnimation(Button.OpacityProperty, opacityAnim);
                ////
                DoubleAnimation opacityAnim1 = new DoubleAnimation();
                opacityAnim1.From = 0.0;
                opacityAnim1.To = 1;
                opacityAnim1.Duration = TimeSpan.FromSeconds(2);
                PanLeft1.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft2.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft3.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft4.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft5.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft6.BeginAnimation(Button.OpacityProperty, opacityAnim1);
               
                ////
                ////
                ////
                ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                thicknessAnimation1.From = new Thickness(-272, 272, 0, 0);
                thicknessAnimation1.To = new Thickness(3, 272, 0,0);
                thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                PanLeft1.BeginAnimation(MarginProperty, thicknessAnimation1);
                //
                ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                thicknessAnimation2.From = new Thickness(-272, 272, 0, 0);
                thicknessAnimation2.To = new Thickness(96, 272, 0, 0);
                thicknessAnimation2.Duration = TimeSpan.FromSeconds(2);
                PanLeft2.BeginAnimation(MarginProperty, thicknessAnimation2);
                //
                ThicknessAnimation thicknessAnimation3 = new ThicknessAnimation();
                thicknessAnimation3.From = new Thickness(-201, 201, 0, 0);
                thicknessAnimation3.To = new Thickness(3, 201, 0, 0);
                thicknessAnimation3.Duration = TimeSpan.FromSeconds(1);
                PanLeft3.BeginAnimation(MarginProperty, thicknessAnimation3);
                //
                ThicknessAnimation thicknessAnimation4 = new ThicknessAnimation();
                thicknessAnimation4.From = new Thickness(-201, 201, 0, 0);
                thicknessAnimation4.To = new Thickness(96, 201, 0, 0);
                thicknessAnimation4.Duration = TimeSpan.FromSeconds(2);
                PanLeft4.BeginAnimation(MarginProperty, thicknessAnimation4);
                //
                ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
                thicknessAnimation5.From = new Thickness(-131, 131, 0, 0);
                thicknessAnimation5.To = new Thickness(3, 131, 0, 0);
                thicknessAnimation5.Duration = TimeSpan.FromSeconds(1);
                PanLeft5.BeginAnimation(MarginProperty, thicknessAnimation5);
                //
                ThicknessAnimation thicknessAnimation6 = new ThicknessAnimation();
                thicknessAnimation6.From = new Thickness(-131, 131, 0, 0);
                thicknessAnimation6.To = new Thickness(96, 131, 0, 0);
                thicknessAnimation6.Duration = TimeSpan.FromSeconds(2);
                PanLeft6.BeginAnimation(MarginProperty, thicknessAnimation6);
                //
              
            }
            else if (ff == 1)
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 200;
                animation.To = 0;
                animation.Duration = TimeSpan.FromSeconds(2);
                PanLeft.BeginAnimation(Button.WidthProperty, animation);
                ff = 0;
                ////
                DoubleAnimation opacityAnim = new DoubleAnimation();
                opacityAnim.From = 1;
                opacityAnim.To = 0.0;
                opacityAnim.Duration = TimeSpan.FromSeconds(3);
                PanLeft.BeginAnimation(Button.OpacityProperty, opacityAnim);
                ////
                DoubleAnimation opacityAnim1 = new DoubleAnimation();
                opacityAnim1.From = 1;
                opacityAnim1.To = 0.0;
                opacityAnim1.Duration = TimeSpan.FromSeconds(2);
                PanLeft1.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft2.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft3.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft4.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft5.BeginAnimation(Button.OpacityProperty, opacityAnim1);
                PanLeft6.BeginAnimation(Button.OpacityProperty, opacityAnim1);

                ////
                ////
                ////
                ThicknessAnimation thicknessAnimation1 = new ThicknessAnimation();
                thicknessAnimation1.From = new Thickness(3, 272, 0, 0);
                thicknessAnimation1.To = new Thickness(-272, 272, 0, 0);
                thicknessAnimation1.Duration = TimeSpan.FromSeconds(1);
                PanLeft1.BeginAnimation(MarginProperty, thicknessAnimation1);
                //
                ThicknessAnimation thicknessAnimation2 = new ThicknessAnimation();
                thicknessAnimation2.From = new Thickness(96, 272, 0, 0);
                thicknessAnimation2.To = new Thickness(-272, 272, 0, 0);
                thicknessAnimation2.Duration = TimeSpan.FromSeconds(2);
                PanLeft2.BeginAnimation(MarginProperty, thicknessAnimation2);
                //
                ThicknessAnimation thicknessAnimation3 = new ThicknessAnimation();
                thicknessAnimation3.From = new Thickness(3, 201, 0, 0);
                thicknessAnimation3.To = new Thickness(-201, 201, 0, 0);
                thicknessAnimation3.Duration = TimeSpan.FromSeconds(1);
                PanLeft3.BeginAnimation(MarginProperty, thicknessAnimation3);
                //
                ThicknessAnimation thicknessAnimation4 = new ThicknessAnimation();
                thicknessAnimation4.From = new Thickness(96, 201, 0, 0);
                thicknessAnimation4.To = new Thickness(-201, 201, 0, 0);
                thicknessAnimation4.Duration = TimeSpan.FromSeconds(2);
                PanLeft4.BeginAnimation(MarginProperty, thicknessAnimation4);
                //
                ThicknessAnimation thicknessAnimation5 = new ThicknessAnimation();
                thicknessAnimation5.From = new Thickness(3, 131, 0, 0);
                thicknessAnimation5.To = new Thickness(-131, 131, 0, 0);
                thicknessAnimation5.Duration = TimeSpan.FromSeconds(1);
                PanLeft5.BeginAnimation(MarginProperty, thicknessAnimation5);
                //
                ThicknessAnimation thicknessAnimation6 = new ThicknessAnimation();
                thicknessAnimation6.From = new Thickness(96, 131, 0, 0);
                thicknessAnimation6.To = new Thickness(-131, 131, 0, 0);
                thicknessAnimation6.Duration = TimeSpan.FromSeconds(2);
                PanLeft6.BeginAnimation(MarginProperty, thicknessAnimation6);
                //

            }
        }
    }
}
