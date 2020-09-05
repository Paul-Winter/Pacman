using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class Wall: IPicture
    {
        WallImg wallImg = new WallImg();
        Image img;

        public Image CurrentImg { get => img; }

        public Wall()
        {
            img = wallImg.Img;
        }
    }
}
