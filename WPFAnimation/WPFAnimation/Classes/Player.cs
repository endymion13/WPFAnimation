using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WPFAnimation.Classes
{
    
    class Player
    {

        public BitmapImage SpriteWalk1 { get; set; }
        public BitmapImage SpriteWalk2 { get; set; }

        private Player()
        {

        }

        public Player(BitmapImage _SpriteWalk1, BitmapImage _SpriteWalk2)
        {
            SpriteWalk1 = _SpriteWalk1;
            SpriteWalk2 = _SpriteWalk2;

        }
        

       
    }
}
