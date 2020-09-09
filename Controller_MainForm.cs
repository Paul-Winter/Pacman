using System;
using System.Threading;
using System.Windows.Forms;
using System.Media;

[assembly: CLSCompliant(false)]
namespace Pacman
{
    delegate void Invoker();

    public partial class ControllerMainForm : Form
    {
        public ControllerMainForm() : this(260) { }
        public ControllerMainForm(int sizeField): this(sizeField, 4) { }
        public ControllerMainForm(int sizeField, int amountTanks): this(sizeField, amountTanks, 5) { }
        public ControllerMainForm(int sizeField, int amountTanks, int amountApples): this(sizeField, amountTanks, amountApples, 40) { }
        public ControllerMainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();
            model = new Model(sizeField, amountTanks, amountApples, speedGame);
            model.ChangeStrip += new STRIP(ChangerStatusStripLabel);
            View = new View(model);
            this.Controls.Add(View);

            isSound = true;

            Sp = new SoundPlayer(Properties.Resources.the_mandalorian_08___The_Mandalorian__online_audio_converter_com_);
        }


        void SetRocketStart()
        {
            model.Rocket.Direct_x = model.Pacman.Direct_x;
            model.Rocket.Direct_y = model.Pacman.Direct_y;
            
            if (model.Pacman.Direct_y == -1)
            {
                model.Rocket.X = model.Pacman.X + 5;
                model.Rocket.Y = model.Pacman.Y;
            }
            if (model.Pacman.Direct_y == 1)
            {
                model.Rocket.X = model.Pacman.X + 5;
                model.Rocket.Y = model.Pacman.Y + 20;
            }
            if (model.Pacman.Direct_x == -1)
            {
                model.Rocket.X = model.Pacman.X;
                model.Rocket.Y = model.Pacman.Y + 5;
            }
            if (model.Pacman.Direct_x == 1)
            {
                model.Rocket.X = model.Pacman.X + 20;
                model.Rocket.Y = model.Pacman.Y + 5;
            }
        }
        void SetValueToStringLabel()
        {
            GameStatus_lbl_st_strp.Text = model.gameStatus.ToString();
            if (isSound)
                if (model.gameStatus == GameStatus.playing)
                Sp.PlayLooping();
                else
                Sp.Stop();
        }
        void ChangerStatusStripLabel()
        {
            Invoke(new Invoker(SetValueToStringLabel));
        }
        void StartPause_btn_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stoping;
                StartPause_pcbx.Image = Properties.Resources.Start;
                ChangerStatusStripLabel();
            }
            else
            {
                StartPause_pcbx.Focus();
                model.gameStatus = GameStatus.playing;
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                StartPause_pcbx.Image = Properties.Resources.Pause;
                ChangerStatusStripLabel();
                View.Invalidate();
            }
        }
        void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game \"Pacman VS Tanks\"\nversion 1.0\nCreated by Paul Winter\n\nPlease WASD to control Pacman\nPress SPACE to attak with rocket", "Pacman VS Tanks", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        void SoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSound = !isSound;
            if (isSound)
                soundToolStripMenuItem.Image = global::Pacman.Properties.Resources.Apple;
            else
                soundToolStripMenuItem.Image = global::Pacman.Properties.Resources.Wall;
        }
        void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.NewGame();
            StartPause_pcbx.Image = Properties.Resources.Start;
            View.Refresh();
        }
        void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                model.gameStatus = GameStatus.stoping;
                modelPlay.Abort();
            }

            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти?", "Pacman", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        /// <summary>
        /// Метод управления пакмэном с клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void StartPause_pcbx_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "A":
                    {
                        model.Pacman.NextDirect_x = -1;
                        model.Pacman.NextDirect_y = 0;
                    }
                    break;

                case "D":
                    {
                        model.Pacman.NextDirect_x = 1;
                        model.Pacman.NextDirect_y = 0;
                    }
                    break;

                case "W":
                    {
                        model.Pacman.NextDirect_x = 0;
                        model.Pacman.NextDirect_y = -1;
                    }
                    break;

                case "S":
                    {
                        model.Pacman.NextDirect_x = 0;
                        model.Pacman.NextDirect_y = 1;
                    }
                    break;

                default:
                    {
                        SetRocketStart();
                    }
                    break;
            } 
        }


        View view;
        Model model;
        Thread modelPlay;
        bool isSound;
        SoundPlayer sp;

        internal View View { get => view; set => view = value; }
        public SoundPlayer Sp { get => sp; set => sp = value; }
    }
}