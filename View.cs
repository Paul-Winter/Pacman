using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pacman
{
    partial class View : UserControl
    {
        Model model;

        
        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }


        void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawFireTank(e);
            DrawApple(e);
            DrawTank(e);
            DrawRocket(e); 
            DrawPacman(e); 
           

            if (model.gameStatus != GameStatus.playing)
                return;

            Thread.Sleep(model.speedGame);
            Invalidate();
        }
        void DrawTank(PaintEventArgs e)
        {
            for (int i = 0; i < model.Tanks.Count; i++)
                e.Graphics.DrawImage(model.Tanks[i].CurrentImg, new Point(model.Tanks[i].X, model.Tanks[i].Y));
        }
        void DrawWall(PaintEventArgs e)
        {
            for (int y = 20; y < 240; y += 40)
                for (int x = 20; x < 240; x += 40)            
                e.Graphics.DrawImage(model.wall.CurrentImg, new Point(x, y));

            for (int x = 0; x < 260; x += 20)
            {
                int y = 260;
                e.Graphics.DrawImage(model.wall.CurrentImg, new Point(x, y));
                y += 20;
            }
        }
        void DrawApple(PaintEventArgs e)
        {
            for (int i = 0; i < model.Apples.Count; i++)
                e.Graphics.DrawImage(model.Apples[i].CurrentImg, new Point(model.Apples[i].X, model.Apples[i].Y));
        }
        void DrawPacman(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Pacman.CurrentImg, new Point(model.Pacman.X, model.Pacman.Y));
        }
        void DrawRocket(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Rocket.CurrentImg, new Point(model.Rocket.X, model.Rocket.Y));
        }
        void DrawFireTank(PaintEventArgs e)
        {
            foreach (FireTank ft in model.FireTanks)
                e.Graphics.DrawImage(ft.CurrentImg, new Point(ft.X, ft.Y));
        }
    }
}
