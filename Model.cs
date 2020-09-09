using System;
using System.Threading;
using System.Collections.Generic;

namespace Pacman
{
    public delegate void STRIP();
    class Model
    {
        public event STRIP ChangeStrip;
        public int speedGame;
        public int AmountTanks { get => amountTanks; set => amountTanks = value; }
        public int AmountApples { get => amountApples; set => amountApples = value; }
        public int CollectedApples { get => collectedApples; set => collectedApples = value; }
        public Wall wall;
        public GameStatus gameStatus;
        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            r = new Random();
            
            this.sizeField = sizeField;
            this.AmountTanks = amountTanks;
            this.AmountApples = amountApples;
            this.speedGame = speedGame;

            NewGame();
        }

        /// <summary>
        /// Метод запускает игру
        /// </summary>
        public void Play()
        {
            while (gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);

                RunAll();
                DestroyTank();
                IfCollisionTank();
                IfCollisionPacman();
                IfPickApple();

                if (CollectedApples >= AmountApples)
                {
                    gameStatus = GameStatus.winner;
                    if (ChangeStrip != null)
                        ChangeStrip();
                }                    
            }
        }


        internal Pacman Pacman
        {
            get { return pacman; }
        }
        internal Rocket Rocket
        {
            get { return rocket; }
        }
        internal List<Tank> Tanks
        {
            get { return tanks; }
        }
        internal List<Apple> Apples
        {
            get { return apples; }
        }
        internal List<FireTank> FireTanks
        {
            get { return fireTanks; }
        }


        /// <summary>
        /// Метод запускает новый раунд игры
        /// </summary>
        internal void NewGame()
        {
            CollectedApples = 0;
            step = -30;
            pacman = new Pacman(sizeField);
            rocket = new Rocket();
            tanks = new List<Tank>();
            fireTanks = new List<FireTank>();
            apples = new List<Apple>();            
 
            CreateTanks();
            CreateApples();
            wall = new Wall();

            gameStatus = GameStatus.stoping;
        }


        int step;
        int sizeField;
        int amountTanks;
        int amountApples;
        int collectedApples;
        static Random r;
        Pacman pacman;
        Rocket rocket;
        List<Tank> tanks;
        List<Apple> apples;
        List<FireTank> fireTanks;


        /// <summary>
        /// Метод приводит в движение все модели
        /// </summary>
        void RunAll()
        {
            pacman.Run();
            rocket.Run();
            ((Hunter)tanks[0]).Run(pacman.X, pacman.Y);

            for (int i = 1; i < tanks.Count; i++)
                tanks[i].Run();

            foreach (FireTank ft in fireTanks)
                ft.Fire();
        }

        /// <summary>
        /// Метод создаёт модели танков
        /// </summary>
        void CreateTanks()
        {
            int x, y;
            while(tanks.Count < AmountTanks + 1)
            {
                if (tanks.Count == 0)
                    tanks.Add(new Hunter(sizeField, r.Next(7) * 40, r.Next(4) * 40));

                x = r.Next(1, 7) * 40;
                y = r.Next(1, 4) * 40;
                bool flag = true;

                foreach (Tank t in tanks)
                {
                    if ((t.X == x) && (t.Y == y))
                    {
                        flag = !flag;
                        break;
                    }
                }
                if (flag)
                    tanks.Add(new Tank(sizeField, x, y));
            }
        }

        /// <summary>
        /// Метод обрабатывающий уничтожение танка
        /// </summary>
        void DestroyTank()
        {
            for (int i = 1; i < tanks.Count; i++)
                if (((rocket.X - tanks[i].X <= 16) && (rocket.Y - tanks[i].Y <= 16)) &&
                    ((rocket.X - tanks[i].X >= 4) && (rocket.Y - tanks[i].Y >= 4)))
                {
                    fireTanks.Add(new FireTank(tanks[i].X, tanks[i].Y, tanks[i].Direct_x, tanks[i].Direct_y));
                    tanks.RemoveAt(i);
                    rocket.DefaultRocket();
                }
        }

        /// <summary>
        /// Метод создаёт модели яблок
        /// </summary>
        void CreateApples()
        {
            CreateApples(0);
        }

        /// <summary>
        /// Метод создаёт модели яблок
        /// </summary>
        /// <param name="newApples"></param>
        void CreateApples(int newApples) 
        {
            int x, y;
            while (apples.Count < (AmountApples + newApples))
            {
                x = r.Next(1, 7) * 40;
                y = r.Next(1, 7) * 40;
                bool flag = true;

                foreach (Apple a in apples)
                    if (a.X == x && a.Y == y)
                    {
                        flag = !flag;
                        break;
                    }

                if (flag)
                    apples.Add(new Apple(x, y));
            }
        }

        /// <summary>
        /// Метод проверяет столкновение танков друг с другом
        /// </summary>
        void IfCollisionTank()
        {
            for (int i = 0; i < tanks.Count - 1; i++)
                for (int j = i + 1; j < tanks.Count; j++)
                    if (
                        ((Math.Abs(tanks[i].X - tanks[j].X) <= 20) && (tanks[i].Y == tanks[j].Y))
                        ||
                        ((Math.Abs(tanks[i].Y - tanks[j].Y) <= 20) && (tanks[i].X == tanks[j].X))
                        ||
                        ((Math.Abs(tanks[i].X - tanks[j].X) <= 20) && (Math.Abs(tanks[i].Y - tanks[j].Y) <= 20))
                        )
                    {
                        if (i == 0)
                            ((Hunter)tanks[i]).TurnAround();
                        else
                            tanks[i].TurnAround();
                        tanks[j].TurnAround();
                    }
        }

        /// <summary>
        /// Метод проверяет поедание Пакмэном яблок
        /// </summary>
        void IfPickApple()
        {
            for (int i = 0; i < apples.Count; i++)
            {
                if ((Math.Abs(pacman.X - apples[i].X) < 2) && (Math.Abs(pacman.Y - apples[i].Y) < 2))
                {
                    apples[i] = new Apple(step += 30, 280);
                    CreateApples(++CollectedApples);
                }
            }
        }

        /// <summary>
        /// Метод проверяет столкновение Пакмэна с танком
        /// </summary>
        void IfCollisionPacman()
        {
            for (int i = 0; i < tanks.Count; i++)
            {
                if (
                        ((Math.Abs(tanks[i].X - pacman.X) <= 19) && (tanks[i].Y == pacman.Y))
                        ||
                        ((Math.Abs(tanks[i].Y - pacman.Y) <= 19) && (tanks[i].X == pacman.X))
                        ||
                        ((Math.Abs(tanks[i].X - pacman.X) <= 19) && (Math.Abs(tanks[i].Y - pacman.Y) <= 19))
                    )
                {
                    gameStatus = GameStatus.looser;
                    if (ChangeStrip != null)
                        ChangeStrip();
                }
            }
        }
    }
}