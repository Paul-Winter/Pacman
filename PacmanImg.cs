using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class PacmanImg
    {
        Image[] up = new Image[]
        {
            Properties.Resources.Pacman0_1,
            Properties.Resources.Pacman0_1I,
            Properties.Resources.Pacman0_1II,
            Properties.Resources.Pacman0_1III,
            Properties.Resources.Pacman0_1IV,
            Properties.Resources.Pacman0_1III,
            Properties.Resources.Pacman0_1II,
            Properties.Resources.Pacman0_1I,
            Properties.Resources.Pacman0_1
        };

        Image[] down = new Image[]
        {
            Properties.Resources.Pacman01,
            Properties.Resources.Pacman01I,
            Properties.Resources.Pacman01II,
            Properties.Resources.Pacman01III,
            Properties.Resources.Pacman01IV,
            Properties.Resources.Pacman01III,
            Properties.Resources.Pacman01II,
            Properties.Resources.Pacman01I,
            Properties.Resources.Pacman01
        };

        Image[] left = new Image[]
        {
            Properties.Resources.Pacman_10,
            Properties.Resources.Pacman_10I,
            Properties.Resources.Pacman_10II,
            Properties.Resources.Pacman_10III,
            Properties.Resources.Pacman_10IV,
            Properties.Resources.Pacman_10III,
            Properties.Resources.Pacman_10II,
            Properties.Resources.Pacman_10I,
            Properties.Resources.Pacman_10
        };

        Image[] right = new Image[]
        {
            Properties.Resources.Pacman10,
            Properties.Resources.Pacman10I,
            Properties.Resources.Pacman10II,
            Properties.Resources.Pacman10III,
            Properties.Resources.Pacman10IV,
            Properties.Resources.Pacman10III,
            Properties.Resources.Pacman10II,
            Properties.Resources.Pacman10I,
            Properties.Resources.Pacman10
        };

        public Image[] Up { get => up; set => up = value; }
        public Image[] Down { get => down; set => down = value; }
        public Image[] Left { get => left; set => left = value; }
        public Image[] Right { get => right; set => right = value; }
    }
}
