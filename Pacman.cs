using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class Pacman: ICurrentPicture, IRun, ITransparent, ITurn
    {
        int k;
        int sizeField;
        int x, y, direct_x, direct_y, nextDirect_x, nextDirect_y;
        Image[] img;
        Image currentImg;
        PacmanImg pacmanImg = new PacmanImg();

        void PutImg()
        {
            if (direct_x == 1)
                img = pacmanImg.Right;
            if (direct_x == -1)
                img = pacmanImg.Left;
            if (direct_y == 1)
                img = pacmanImg.Down;
            if (direct_y == -1)
                img = pacmanImg.Up;
        }
        void PutCurrentImage()
        {
            currentImg = img[k];
            k++;
            if (k == img.Length)
                k = 0;
        }


        public Image CurrentImg
        {
            get { return currentImg; }
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public int Direct_x
        {
            get { return direct_x; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    direct_x = value;
                else
                    direct_x = 0;
            }
        }
        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    direct_y = value;
                else
                    direct_y = 0;
            }
        }
        public int NextDirect_x
        {
            get { return nextDirect_x; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    nextDirect_x = value;
                else
                    nextDirect_x = 0;
            }
        }
        public int NextDirect_y
        {
            get { return nextDirect_y; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    nextDirect_y = value;
                else
                    nextDirect_y = 0;
            }
        }

        public Pacman(int sizeField)
        {
            this.sizeField = sizeField;
            this.x = 120;
            this.y = 240;
            this.Direct_x = 1;
            this.Direct_y = 0;

            PutImg();
            PutCurrentImage();
        }
        public void Run()
        {
            x += direct_x;
            y += direct_y;
            if ((Math.IEEERemainder(x, 40) == 0) && (Math.IEEERemainder(y, 40) == 0))
                Turn();

            PutCurrentImage();
            Transparent();
        }
        public void Turn()
        {
            Direct_x = NextDirect_x;
            Direct_y = NextDirect_y;

            PutImg();
        }
        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 19)
                x = 1;
            if (y == -1)
                y = sizeField - 21;
            if (y == sizeField - 19)
                y = 1;
        }
    }
}
