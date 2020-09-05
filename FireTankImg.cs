using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class FireTankImg
    {
        Image[] up = new Image[]
{
            Properties.Resources.Fire0_1,
            Properties.Resources.Fire0_1I,
            Properties.Resources.Fire0_1II,
            Properties.Resources.Fire0_1II,
            Properties.Resources.Fire0_1I,
            Properties.Resources.Fire0_1
 
};

        Image[] down = new Image[]
        {
            Properties.Resources.Fire01,
            Properties.Resources.Fire01I,
            Properties.Resources.Fire01II,
            Properties.Resources.Fire01II,
            Properties.Resources.Fire01I,
            Properties.Resources.Fire01I,
            Properties.Resources.Fire01
        };

        Image[] left = new Image[]
        {
            Properties.Resources.Fire_10,
            Properties.Resources.Fire_10I,
            Properties.Resources.Fire_10II,
            Properties.Resources.Fire_10II,
            Properties.Resources.Fire_10I,
            Properties.Resources.Fire_10I,
            Properties.Resources.Fire_10
        };

        Image[] right = new Image[]
        {
            Properties.Resources.Fire10,
            Properties.Resources.Fire10I,
            Properties.Resources.Fire10II,
            Properties.Resources.Fire10II,
            Properties.Resources.Fire10I,
            Properties.Resources.Fire10I,
            Properties.Resources.Fire10
        };

        public Image[] Up { get => up; }
        public Image[] Down { get => down; }
        public Image[] Left { get => left; }
        public Image[] Right { get => right; }
    }
}
