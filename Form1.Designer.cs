
namespace Running_Bot
{
    partial class PlayGround
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGround));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.JumpController = new System.Windows.Forms.Label();
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.zobrazeniCoin = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.btnMute = new System.Windows.Forms.Button();
            this.poleLogo = new System.Windows.Forms.PictureBox();
            this.PlayHard = new System.Windows.Forms.Button();
            this.PlayNormal = new System.Windows.Forms.Button();
            this.PlayEasy = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.poleMonitorCoin = new System.Windows.Forms.PictureBox();
            this.poleMonitorLive = new System.Windows.Forms.PictureBox();
            this.Spanner = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.DownGround = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleMonitorCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleMonitorLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownGround)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JumpController
            // 
            this.JumpController.AutoSize = true;
            this.JumpController.Location = new System.Drawing.Point(12, 624);
            this.JumpController.Name = "JumpController";
            this.JumpController.Size = new System.Drawing.Size(76, 13);
            this.JumpController.TabIndex = 4;
            this.JumpController.Text = "JumpController";
            this.JumpController.Visible = false;
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Interval = 20;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Interval = 1000;
            this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // zobrazeniCoin
            // 
            this.zobrazeniCoin.AutoSize = true;
            this.zobrazeniCoin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.zobrazeniCoin.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zobrazeniCoin.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.zobrazeniCoin.Location = new System.Drawing.Point(980, 68);
            this.zobrazeniCoin.Name = "zobrazeniCoin";
            this.zobrazeniCoin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.zobrazeniCoin.Size = new System.Drawing.Size(58, 29);
            this.zobrazeniCoin.TabIndex = 11;
            this.zobrazeniCoin.Text = "  0";
            // 
            // GamePanel
            // 
            this.GamePanel.BackgroundImage = global::Running_Bot.Properties.Resources.MainPanel;
            this.GamePanel.Controls.Add(this.btnMute);
            this.GamePanel.Controls.Add(this.poleLogo);
            this.GamePanel.Controls.Add(this.PlayHard);
            this.GamePanel.Controls.Add(this.PlayNormal);
            this.GamePanel.Controls.Add(this.PlayEasy);
            this.GamePanel.Location = new System.Drawing.Point(434, 150);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(344, 377);
            this.GamePanel.TabIndex = 6;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.LightBlue;
            this.btnMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.Image = global::Running_Bot.Properties.Resources.SoundOn;
            this.btnMute.Location = new System.Drawing.Point(266, 48);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(30, 30);
            this.btnMute.TabIndex = 7;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            this.btnMute.Enter += new System.EventHandler(this.LostFokus_Enter);
            // 
            // poleLogo
            // 
            this.poleLogo.BackColor = System.Drawing.Color.Silver;
            this.poleLogo.Image = global::Running_Bot.Properties.Resources.ByHenry005czLogo;
            this.poleLogo.Location = new System.Drawing.Point(26, 315);
            this.poleLogo.Name = "poleLogo";
            this.poleLogo.Size = new System.Drawing.Size(234, 36);
            this.poleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poleLogo.TabIndex = 5;
            this.poleLogo.TabStop = false;
            this.poleLogo.Visible = false;
            // 
            // PlayHard
            // 
            this.PlayHard.BackgroundImage = global::Running_Bot.Properties.Resources.Button1;
            this.PlayHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayHard.Location = new System.Drawing.Point(97, 216);
            this.PlayHard.Name = "PlayHard";
            this.PlayHard.Size = new System.Drawing.Size(163, 52);
            this.PlayHard.TabIndex = 2;
            this.PlayHard.Text = "Hard";
            this.PlayHard.UseVisualStyleBackColor = true;
            this.PlayHard.Click += new System.EventHandler(this.PlayHard_Click);
            this.PlayHard.Enter += new System.EventHandler(this.LostFokus_Enter);
            this.PlayHard.MouseEnter += new System.EventHandler(this.PlayHard_MouseEnter);
            this.PlayHard.MouseLeave += new System.EventHandler(this.PlayHard_MouseLeave);
            // 
            // PlayNormal
            // 
            this.PlayNormal.BackgroundImage = global::Running_Bot.Properties.Resources.Button1;
            this.PlayNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayNormal.Location = new System.Drawing.Point(97, 135);
            this.PlayNormal.Name = "PlayNormal";
            this.PlayNormal.Size = new System.Drawing.Size(163, 52);
            this.PlayNormal.TabIndex = 0;
            this.PlayNormal.TabStop = false;
            this.PlayNormal.Text = "Normal";
            this.PlayNormal.UseVisualStyleBackColor = true;
            this.PlayNormal.Click += new System.EventHandler(this.PlayNormal_Click);
            this.PlayNormal.Enter += new System.EventHandler(this.LostFokus_Enter);
            this.PlayNormal.MouseEnter += new System.EventHandler(this.PlayNormal_MouseEnter);
            this.PlayNormal.MouseLeave += new System.EventHandler(this.PlayNormal_MouseLeave);
            // 
            // PlayEasy
            // 
            this.PlayEasy.BackColor = System.Drawing.Color.SkyBlue;
            this.PlayEasy.BackgroundImage = global::Running_Bot.Properties.Resources.Button1;
            this.PlayEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayEasy.Location = new System.Drawing.Point(97, 58);
            this.PlayEasy.Name = "PlayEasy";
            this.PlayEasy.Size = new System.Drawing.Size(163, 52);
            this.PlayEasy.TabIndex = 1;
            this.PlayEasy.Text = "Easy";
            this.PlayEasy.UseVisualStyleBackColor = false;
            this.PlayEasy.Click += new System.EventHandler(this.PlayEasy_Click);
            this.PlayEasy.Enter += new System.EventHandler(this.LostFokus_Enter);
            this.PlayEasy.MouseEnter += new System.EventHandler(this.PlayEasy_MouseEnter);
            this.PlayEasy.MouseLeave += new System.EventHandler(this.PlayEasy_MouseLeave);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Running_Bot.Properties.Resources.Bitcoin;
            this.pictureBox10.Location = new System.Drawing.Point(-24, 262);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(75, 75);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "Coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Running_Bot.Properties.Resources.Bitcoin;
            this.pictureBox9.Location = new System.Drawing.Point(-24, 262);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 75);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "Coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Running_Bot.Properties.Resources.Bitcoin;
            this.pictureBox8.Location = new System.Drawing.Point(-24, 262);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 75);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "Coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Running_Bot.Properties.Resources.Rocket1_0;
            this.pictureBox7.Location = new System.Drawing.Point(-37, 343);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(88, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "EnemyRocket";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Running_Bot.Properties.Resources.Rocket1_0;
            this.pictureBox6.Location = new System.Drawing.Point(-37, 343);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "EnemyRocket";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Running_Bot.Properties.Resources.spanner;
            this.pictureBox5.Location = new System.Drawing.Point(-24, 391);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Heal";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Running_Bot.Properties.Resources.BrickWall1_0;
            this.pictureBox4.Location = new System.Drawing.Point(-30, 492);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "EnemyWall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Running_Bot.Properties.Resources.BrickWall1_0;
            this.pictureBox3.Location = new System.Drawing.Point(-30, 492);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "EnemyWall";
            // 
            // poleMonitorCoin
            // 
            this.poleMonitorCoin.BackColor = System.Drawing.Color.Transparent;
            this.poleMonitorCoin.Image = ((System.Drawing.Image)(resources.GetObject("poleMonitorCoin.Image")));
            this.poleMonitorCoin.Location = new System.Drawing.Point(940, 12);
            this.poleMonitorCoin.Name = "poleMonitorCoin";
            this.poleMonitorCoin.Size = new System.Drawing.Size(174, 136);
            this.poleMonitorCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poleMonitorCoin.TabIndex = 10;
            this.poleMonitorCoin.TabStop = false;
            // 
            // poleMonitorLive
            // 
            this.poleMonitorLive.BackColor = System.Drawing.Color.Transparent;
            this.poleMonitorLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poleMonitorLive.Image = global::Running_Bot.Properties.Resources.Monitor;
            this.poleMonitorLive.Location = new System.Drawing.Point(1120, 12);
            this.poleMonitorLive.Name = "poleMonitorLive";
            this.poleMonitorLive.Size = new System.Drawing.Size(174, 136);
            this.poleMonitorLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poleMonitorLive.TabIndex = 9;
            this.poleMonitorLive.TabStop = false;
            this.poleMonitorLive.Paint += new System.Windows.Forms.PaintEventHandler(this.poleMonitorLive_Paint);
            // 
            // Spanner
            // 
            this.Spanner.BackColor = System.Drawing.Color.Transparent;
            this.Spanner.Image = global::Running_Bot.Properties.Resources.spanner;
            this.Spanner.Location = new System.Drawing.Point(-24, 391);
            this.Spanner.Name = "Spanner";
            this.Spanner.Size = new System.Drawing.Size(75, 75);
            this.Spanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Spanner.TabIndex = 12;
            this.Spanner.TabStop = false;
            this.Spanner.Tag = "Heal";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = global::Running_Bot.Properties.Resources.Bot1;
            this.Player.Location = new System.Drawing.Point(57, 354);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(150, 200);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Running_Bot.Properties.Resources.Rocket1_0;
            this.pictureBox2.Location = new System.Drawing.Point(-37, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "EnemyRocket";
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.White;
            this.Wall1.Image = global::Running_Bot.Properties.Resources.BrickWall1_0;
            this.Wall1.Location = new System.Drawing.Point(-30, 492);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(81, 62);
            this.Wall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wall1.TabIndex = 7;
            this.Wall1.TabStop = false;
            this.Wall1.Tag = "EnemyWall";
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.ForestGreen;
            this.Ground.BackgroundImage = global::Running_Bot.Properties.Resources.Ground;
            this.Ground.Location = new System.Drawing.Point(0, 550);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(3600, 101);
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.BackColor = System.Drawing.Color.Transparent;
            this.Coin1.Image = global::Running_Bot.Properties.Resources.Bitcoin;
            this.Coin1.Location = new System.Drawing.Point(-24, 262);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(75, 75);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin1.TabIndex = 2;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "Coin";
            // 
            // DownGround
            // 
            this.DownGround.BackColor = System.Drawing.Color.Lime;
            this.DownGround.Location = new System.Drawing.Point(0, 644);
            this.DownGround.Name = "DownGround";
            this.DownGround.Size = new System.Drawing.Size(1307, 57);
            this.DownGround.TabIndex = 22;
            this.DownGround.TabStop = false;
            // 
            // PlayGround
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::Running_Bot.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(1306, 671);
            this.Controls.Add(this.zobrazeniCoin);
            this.Controls.Add(this.poleMonitorCoin);
            this.Controls.Add(this.poleMonitorLive);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Spanner);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Wall1);
            this.Controls.Add(this.JumpController);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.DownGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayGround";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Running Bot version 1.0";
            this.SizeChanged += new System.EventHandler(this.PlayGround_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayGround_KeyUp);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleMonitorCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleMonitorLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label JumpController;
        private System.Windows.Forms.PictureBox poleLogo;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button PlayNormal;
        private System.Windows.Forms.PictureBox Wall1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.PictureBox poleMonitorLive;
        private System.Windows.Forms.Timer ErrorTimer;
        private System.Windows.Forms.PictureBox poleMonitorCoin;
        private System.Windows.Forms.Label zobrazeniCoin;
        private System.Windows.Forms.Button PlayHard;
        private System.Windows.Forms.Button PlayEasy;
        private System.Windows.Forms.PictureBox Spanner;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.PictureBox DownGround;
    }
}

