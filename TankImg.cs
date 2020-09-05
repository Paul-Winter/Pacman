using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class TankImg
    {
        Image[] up = new Image[]
        {
            Properties.Resources.Tank0_1,
            Properties.Resources.Tank0_1I,
            Properties.Resources.Tank0_1II,
            Properties.Resources.Tank0_1,
            Properties.Resources.Tank0_1I,
            Properties.Resources.Tank0_1II,
            Properties.Resources.Tank0_1,
            Properties.Resources.Tank0_1I,
            Properties.Resources.Tank0_1II
        };

        Image[] down = new Image[]
        {
            Properties.Resources.Tank01,
            Properties.Resources.Tank01I,
            Properties.Resources.Tank01II,
            Properties.Resources.Tank01,
            Properties.Resources.Tank01I,
            Properties.Resources.Tank01II,
            Properties.Resources.Tank01,
            Properties.Resources.Tank01I,
            Properties.Resources.Tank01II
        };

        Image[] left = new Image[]
        {
            Properties.Resources.Tank_10,
            Properties.Resources.Tank_10I,
            Properties.Resources.Tank_10II,
            Properties.Resources.Tank_10,
            Properties.Resources.Tank_10I,
            Properties.Resources.Tank_10II,
            Properties.Resources.Tank_10,
            Properties.Resources.Tank_10I,
            Properties.Resources.Tank_10II
        };

        Image[] right = new Image[]
        {
            Properties.Resources.Tank10,
            Properties.Resources.Tank10I,
            Properties.Resources.Tank10II,
            Properties.Resources.Tank10,
            Properties.Resources.Tank10I,
            Properties.Resources.Tank10II,
            Properties.Resources.Tank10,
            Properties.Resources.Tank10I,
            Properties.Resources.Tank10II
        };

        public Image[] Up { get => up; }
        public Image[] Down { get => down; }
        public Image[] Left { get => left; }
        public Image[] Right { get => right; }
    }
}
