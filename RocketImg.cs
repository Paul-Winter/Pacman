using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class RocketImg
    {
        Image[] up = new Image[]
        {
            Properties.Resources.Rocket0_1,
            Properties.Resources.Rocket0_1I,
            Properties.Resources.Rocket0_1II,
            Properties.Resources.Rocket0_1II,
            Properties.Resources.Rocket0_1I,
            Properties.Resources.Rocket0_1
        };

        Image[] down = new Image[]
        {
            Properties.Resources.Rocket01,
            Properties.Resources.Rocket01I,
            Properties.Resources.Rocket01II,
            Properties.Resources.Rocket01II,
            Properties.Resources.Rocket01I,
            Properties.Resources.Rocket01
        };

        Image[] left = new Image[]
        {
            Properties.Resources.Rocket_10,
            Properties.Resources.Rocket_10I,
            Properties.Resources.Rocket_10II,
            Properties.Resources.Rocket_10II,
            Properties.Resources.Rocket_10I,
            Properties.Resources.Rocket_10
        };

        Image[] right = new Image[]
        {
            Properties.Resources.Rocket10,
            Properties.Resources.Rocket10I,
            Properties.Resources.Rocket10II,
            Properties.Resources.Rocket10II,
            Properties.Resources.Rocket10I,
            Properties.Resources.Rocket10
        };

        public Image[] Up { get => up; }
        public Image[] Down { get => down; }
        public Image[] Left { get => left; }
        public Image[] Right { get => right; }
    }
}
