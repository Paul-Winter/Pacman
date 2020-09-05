using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class Apple: IPicture
    {
        AppleImg appleImg = new AppleImg();
        Image img;

        int x, y;

        public Image CurrentImg
        {
            get { return img; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Apple(int x, int y)
        {
            img = appleImg.Img;
            this.x = x;
            this.y = y;
        }
    }
}
