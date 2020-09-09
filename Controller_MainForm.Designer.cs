namespace Pacman
{
    partial class ControllerMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerMainForm));
            this.StartPause_pcbx = new System.Windows.Forms.PictureBox();
            this.Help_ttip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbApplesAmount = new System.Windows.Forms.ToolStripComboBox();
            this.tscbTanksAmount = new System.Windows.Forms.ToolStripComboBox();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GameStatus_lbl_st_strp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstbApplesAmount = new System.Windows.Forms.ToolStripTextBox();
            this.tstbTanksAmount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbTanks = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartPause_pcbx)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPause_pcbx
            // 
            this.StartPause_pcbx.BackgroundImage = global::Pacman.Properties.Resources.Start;
            this.StartPause_pcbx.Location = new System.Drawing.Point(267, 32);
            this.StartPause_pcbx.Name = "StartPause_pcbx";
            this.StartPause_pcbx.Size = new System.Drawing.Size(80, 80);
            this.StartPause_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartPause_pcbx.TabIndex = 0;
            this.StartPause_pcbx.TabStop = false;
            this.Help_ttip.SetToolTip(this.StartPause_pcbx, "Click the button to start or pause game");
            this.StartPause_pcbx.Click += new System.EventHandler(this.StartPause_btn_Click);
            this.StartPause_pcbx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.StartPause_pcbx_PreviewKeyDown);
            // 
            // Help_ttip
            // 
            this.Help_ttip.AutomaticDelay = 200;
            this.Help_ttip.IsBalloon = true;
            this.Help_ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Help_ttip.ToolTipTitle = "Pacman VS Tanks";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = global::Pacman.Properties.Resources.Pacman10;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "&New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Pacman.Properties.Resources.Hunter10;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.toolStripSeparator2,
            this.tstbApplesAmount,
            this.tscbApplesAmount,
            this.toolStripSeparator3,
            this.tstbTanks,
            this.tscbTanksAmount});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Image = global::Pacman.Properties.Resources.Apple;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.soundToolStripMenuItem.Text = "&Sound";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.SoundToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // tscbApplesAmount
            // 
            this.tscbApplesAmount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.tscbApplesAmount.Name = "tscbApplesAmount";
            this.tscbApplesAmount.Size = new System.Drawing.Size(121, 23);
            this.tscbApplesAmount.Text = "5";
            this.tscbApplesAmount.SelectedIndexChanged += new System.EventHandler(this.tscbApplesAmount_SelectedIndexChanged);
            // 
            // tscbTanksAmount
            // 
            this.tscbTanksAmount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.tscbTanksAmount.Name = "tscbTanksAmount";
            this.tscbTanksAmount.Size = new System.Drawing.Size(121, 23);
            this.tscbTanksAmount.Text = "5";
            this.tscbTanksAmount.SelectedIndexChanged += new System.EventHandler(this.tscbTanksAmount_SelectedIndexChanged);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Pacman.Properties.Resources.Rocket10;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameStatus_lbl_st_strp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(354, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GameStatus_lbl_st_strp
            // 
            this.GameStatus_lbl_st_strp.BackColor = System.Drawing.Color.Silver;
            this.GameStatus_lbl_st_strp.Name = "GameStatus_lbl_st_strp";
            this.GameStatus_lbl_st_strp.Size = new System.Drawing.Size(0, 17);
            // 
            // tstbApplesAmount
            // 
            this.tstbApplesAmount.Name = "tstbApplesAmount";
            this.tstbApplesAmount.ReadOnly = true;
            this.tstbApplesAmount.Size = new System.Drawing.Size(100, 23);
            this.tstbApplesAmount.Text = "Apples";
            // 
            // tstbTanksAmount
            // 
            this.tstbTanksAmount.Name = "tstbTanksAmount";
            this.tstbTanksAmount.Size = new System.Drawing.Size(100, 23);
            this.tstbTanksAmount.Text = "Tanks";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // tstbTanks
            // 
            this.tstbTanks.Name = "tstbTanks";
            this.tstbTanks.ReadOnly = true;
            this.tstbTanks.Size = new System.Drawing.Size(100, 23);
            this.tstbTanks.Text = "Tanks";
            // 
            // ControllerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(354, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StartPause_pcbx);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "ControllerMainForm";
            this.Text = "Pacman VS Tanks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StartPause_pcbx)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartPause_pcbx;
        private System.Windows.Forms.ToolTip Help_ttip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel GameStatus_lbl_st_strp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tscbApplesAmount;
        private System.Windows.Forms.ToolStripComboBox tscbTanksAmount;
        private System.Windows.Forms.ToolStripTextBox tstbApplesAmount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox tstbTanksAmount;
        private System.Windows.Forms.ToolStripTextBox tstbTanks;
    }
}

