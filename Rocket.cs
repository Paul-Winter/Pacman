using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class Rocket: ICurrentPicture, IRun
    {
        RocketImg rocketImg = new RocketImg();
        private int range;
        Image currentImg;       
        Image[] img;
        int x, y, direct_x, direct_y;

        public Image CurrentImg
        {
            get { return currentImg; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Direct_x
        {
            get { return direct_x; }
            set { direct_x = value; }
        }
        public int Direct_y
        {
            get { return direct_y; }
            set { direct_y = value; }
        }

        public Rocket()
        {

            DefaultRocket();
            PutImg();
            PutCurrentImage();
        }

        public void DefaultRocket()
        {
            x = y = -20;
            direct_x = direct_y = 0;
            range = 0;
        }

        public void Run()
        {
            if ((direct_x == 0) && (direct_y == 0))
                return;
            range += 3;
            x += direct_x*3;
            y += direct_y*3;
            PutImg();
            PutCurrentImage();
            if (range > 120)
                DefaultRocket();
        }

        int k;
        private void PutCurrentImage()
        {
            currentImg = img[k];
            k++;
            if (k == img.Length)
                k = 0;
        }

        void PutImg()
        {
            if (direct_x == 1)
                img = rocketImg.Right;
            if (direct_x == -1)
                img = rocketImg.Left;
            if (direct_y == 1)
                img = rocketImg.Down;
            if (direct_y == -1)
                img = rocketImg.Up;
            if ((direct_x == 0) && (direct_y == 0))
                img = rocketImg.Right;
        }
    }
}
