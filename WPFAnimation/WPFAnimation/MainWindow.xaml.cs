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
