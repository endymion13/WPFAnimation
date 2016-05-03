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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAnimation.Controls
{
    /// <summary>
    /// Interaction logic for ctrlTransition.xaml
    /// </summary>
    public partial class ctrlTransition : UserControl
    {
        public ctrlTransition()
        {
            InitializeComponent();

           

        }

        private void rect_MouseEvent(object sender, MouseEventArgs e)
        {
            if (rect.IsMouseOver)
            {
                VisualStateManager.GoToElementState(rect, "MouseEnter", true);
            }
            else
            {
                VisualStateManager.GoToElementState(rect, "MouseLeave", true);
            }
        }
    }
}
