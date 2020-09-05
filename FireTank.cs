using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class FireTank: ICurrentPicture
    {
        int k;
        int x, y, direct_x, direct_y;
        Image[] img;
        Image currentImg;
        FireTankImg ftImg = new FireTankImg();
        void PutImg()
        {
            if (direct_x == 1)
                img = ftImg.Right;
            if (direct_x == -1)
                img = ftImg.Left;
            if (direct_y == 1)
                img = ftImg.Down;
            if (direct_y == -1)
                img = ftImg.Up;
        }


        public Image CurrentImg { get => currentImg; }
        public int X { get => x; }
        public int Y { get => y; }
        public int Direct_x { get => direct_x; }
        public int Direct_y { get => direct_y; }
        public FireTank(int x, int y, int direct_x, int direct_y)
        {
            this.x = x;
            this.y = y;
            this.direct_x = direct_x;
            this.direct_y = direct_y;

            PutImg();
            PutCurrentImage();
        }
        public void Fire()
        {
            PutCurrentImage();
        }
        public void PutCurrentImage()
        {
            currentImg = img[k];
            k++;
            if (k == img.Length)
                k = 0;
        }
    }
}
