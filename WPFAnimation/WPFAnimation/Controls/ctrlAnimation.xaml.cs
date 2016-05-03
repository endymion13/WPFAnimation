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
using System.Windows.Threading;
using WPFAnimation.Classes;

namespace WPFAnimation.Controls
{
    /// <summary>
    /// Interaction logic for ctrlAnimation.xaml
    /// </summary>
    public partial class ctrlAnimation : UserControl
    {
        private int index = 1;
        private DispatcherTimer timer;
        private DispatcherTimer timerGameOver;
        
        public ctrlAnimation()
        {
            InitializeComponent();
           
            song1.LoadedBehavior = MediaState.Manual;
            song2.LoadedBehavior = MediaState.Manual;

          
            song2.Volume = 0.2;

            song1.Play();

            MovePlayer();
            
        }

        public void MovePlayer()
        {
           
                this.timer = new DispatcherTimer(DispatcherPriority.Render);
                this.timer.Interval = TimeSpan.FromMilliseconds(200.0);
                this.timer.Tick += new EventHandler(this.updateImage);
                this.timer.Start();

                this.timerGameOver = new System.Windows.Threading.DispatcherTimer();
                this.timerGameOver.Interval = TimeSpan.FromMilliseconds(10000.0);
                this.timerGameOver.Tick += new EventHandler(timerGameOver_Tick);
                this.timerGameOver.Start();
            
        }

        private void timerGameOver_Tick(object sender, EventArgs e)
        {
            imgPlayerSpriteGameOver.Visibility = Visibility.Visible;

            imgPlayerSprite1.Visibility = Visibility.Hidden;
            imgPlayerSprite2.Visibility = Visibility.Hidden;

            timer.Stop();

            song1.Stop();
            song2.Play();
        }

        private void updateImage(object sender, EventArgs e)
        {
            if (index == 1)
            {
                imgPlayerSprite1.Visibility = Visibility.Hidden;
                imgPlayerSprite2.Visibility = Visibility.Visible;
                index++;
            }
            else
            {
                imgPlayerSprite2.Visibility = Visibility.Hidden;
                imgPlayerSprite1.Visibility = Visibility.Visible;
                index--;
            }
        }

    }
}
