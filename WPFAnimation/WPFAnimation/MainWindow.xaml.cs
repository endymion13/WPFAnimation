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
using WPFAnimation.Controls;


namespace WPFAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Events
        public MainWindow()
        {
            InitializeComponent();      
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlAnimation ctrlAnimationPanel = new ctrlAnimation();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void btnTimelines_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlTimelines ctrlAnimationPanel = new ctrlTimelines();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
        private void btnKeyFrame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlKeyFrame ctrlAnimationPanel = new ctrlKeyFrame();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void btnPathAnimation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlPathAnimation ctrlAnimationPanel = new ctrlPathAnimation();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void btnClock_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlClocks ctrlAnimationPanel = new ctrlClocks();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void btnTransition_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlTransition ctrlAnimationPanel = new ctrlTransition();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void btnMultimedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearAnimationPanel();

                ctrlMultimedia ctrlAnimationPanel = new ctrlMultimedia();
                pnlAnimations.Children.Add(ctrlAnimationPanel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }


        #endregion

        #region Methods

        private void ClearAnimationPanel()
        {
            try
            {
                if (pnlAnimations.Children.Count > 0)
                {
                    pnlAnimations.Children.RemoveRange(0, pnlAnimations.Children.Count);
                }
             }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }




        #endregion

     
    }
}
