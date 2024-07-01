using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Running_Bot
{
    public partial class PlayGround : Form
    {
        public PlayGround()
        {
            InitializeComponent();
        }

        //HLAVNÍ PROMĚNNÉ
        int playerY = 350;
        int playerMaxY = 350;
        int JumpSpeed = 0;
        bool Jumping = false;
        int gravity = 1;
        bool falling = false;
        bool isPushed = false;
        bool DoOne = true;
        int Live = 3;
        int Coin = 0;
        int add;
        bool immortal = false;
        int RunSpeed;
        int HeightMax = 10;
        int GameMode;
        bool Dead = false;
        Random random = new Random();
        System.Media.SoundPlayer JumpSound = new System.Media.SoundPlayer(Properties.Resources.Jumpsound);
        System.Media.SoundPlayer BackGroundSound = new System.Media.SoundPlayer(Properties.Resources.BackgroundSound);
        System.Media.SoundPlayer GameOverSound = new System.Media.SoundPlayer(Properties.Resources.GameOverSound);
        int score;
        int hightscore;
        bool NowPlay = false;
        bool SoundMute = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (JumpSpeed > 5)
                isPushed = true;

            if (isPushed == false)
            { 
            switch(e.KeyCode)
                {
                case Keys.Space:
                        if (Dead == false)
                        {     
                    Jumping = true;
                    JumpSpeed++;
                    JumpSpeed = JumpSpeed * (RunSpeed / 4);
                        }
                        break;
                }
            }
            else
            {
                Jumping = false;
                JumpSpeed = 4;
                if (DoOne == true)
                {
                    DoOne = false;
                    falling = true;
                }
            }
        }
        private void PlayGround_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            { 
             case Keys.Space:
                    Jumping = false;
                    JumpSpeed = 0;
                    falling = true;
                    isPushed = true;
                    DoOne = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playerY > playerMaxY)
            { 
                falling = false;
                playerY = playerMaxY;
                isPushed = false;
            }
            if (Jumping)
            { 
                for (int a= 0; a < 11;a++)
                playerY -= JumpSpeed;
                if (Player.Top < HeightMax)
                {
                    Jumping = false;
                    JumpSpeed = 0;
                    falling = true;
                    isPushed = true;
                    DoOne = true;
                }

            }


            JumpController.Text = Convert.ToString(JumpSpeed);

            if (!Jumping && falling)
            {
                for (int b = 0; b < 10; b++)
                    playerY += gravity * (RunSpeed / GameMode);
            }
            Player.Top = playerY;
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "EnemyWall")
                {
                    x.Left -= RunSpeed;
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        add = random.Next(1000, 5000);
                        x.Left += add;
                        if (immortal == false)
                        {
                            Live -= 1;
                            poleMonitorLive.Refresh();
                            Player.Image = Properties.Resources.BotDamage;
                            ErrorTimer.Start();
                            immortal = true;
                        }
                    }
                    if (x.Left < 0)
                    {
                        add = random.Next(1000, 5000);
                        x.Left += add;
                    }
                }
                if (x is PictureBox && x.Tag == "EnemyRocket")
                {
                    x.Left -= RunSpeed * 2;
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        add = random.Next(1000, 5000);
                        x.Left += add;
                        add = random.Next(50, 300);
                        x.Top = add;
                        if (immortal == false)
                        {
                            Live -= 1;
                            poleMonitorLive.Refresh();
                            Player.Image = Properties.Resources.BotDamage;
                            immortal = true;
                            ErrorTimer.Start();
                        }
                    }
                    if (x.Left < 0)
                    {
                        add = random.Next(1000, 5000);
                        x.Left += add;
                        add = random.Next(50, 300);
                        x.Top = add;
                    }
                }
                if (x is PictureBox && x.Tag == "Coin")
                {
                    x.Left -= RunSpeed * 2;
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        add = random.Next(1000, 5000);
                        x.Left += add;
                        add = random.Next(50, 300);
                        x.Top = add;
                        Coin++;
                        zobrazeniCoin.Text = Convert.ToString(Coin);
                    }
                    if (x.Left < 0)
                    {
                        add = random.Next(1000, 5000);
                        x.Left += add;
                        add = random.Next(50, 300);
                        x.Top = add;
                    }    
                }
                if (x is PictureBox && x.Tag == "Heal")
                {
                    x.Left -= RunSpeed * 2;
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        add = random.Next(3000, 10000);
                        x.Left += add;
                        add = random.Next(50, 300);
                        x.Top = add;
                        Live++;
                        if (Live == 4)
                            Live = 3;
                        poleMonitorLive.Refresh();
                    }
                    if (x.Left < 0)
                    {
                        add = random.Next(2000, 10000);
                        x.Left += add;
                        add = random.Next(50, 300);
                        x.Top = add;
                    }

                }
                //Ground walk
                Ground.Left -= RunSpeed / 4;
                if (Ground.Left < -1300)
                    Ground.Left = 0;
            }
        }

        private void poleMonitorLive_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            if (Live == 3)
                kp.DrawImage(Properties.Resources.Heart3,0,0);
            if (Live == 2)
                kp.DrawImage(Properties.Resources.Heart2, 0, 0);
            if (Live == 1)
                kp.DrawImage(Properties.Resources.Heart1, 0, 0);
            if (Live < 1)
            { 
                kp.DrawImage(Properties.Resources.Heart0, 0, 0);
            }
        }

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            immortal = false;
            if (Live > 0)
            { 
            Player.Image = Properties.Resources.BotWalk;
            }
            if (Live < 1)
            {
                Dead = true;
                Player.Image = Properties.Resources.BotDead;
                if (SoundMute == false)
                GameOverSound.Play();
                timer1.Stop();
                EnemyTimer.Stop();
                if (Coin == 3)
                {    
                    poleLogo.Visible = true;
                    JumpController.Visible = true;
                }
                Coin = 0;
                GamePanel.Visible = true;
                Live = 3;
                poleMonitorLive.Refresh();
            }
            ErrorTimer.Stop();
        }

        private void PlayEasy_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gravity = 1;
            RunSpeed = 5;
            GameMode = 5;
            this.ActiveControl = null;
            if (SoundMute == false)
            BackGroundSound.PlayLooping();
            GamePanel.Visible = false;
            PlayNormal.TabStop = false;
            Player.Image = Properties.Resources.BotWalk;
            EnemyTimer.Interval = 20;
            EnemyTimer.Start();
            NowPlay = true;
            Dead = false;
        }

        private void PlayNormal_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gravity = 1;
            RunSpeed = 10;
            GameMode = 4;
            this.ActiveControl = null;
            if (SoundMute == false)
                BackGroundSound.PlayLooping();
            GamePanel.Visible = false;
            PlayNormal.TabStop = false;
            Player.Image = Properties.Resources.BotWalk;
            EnemyTimer.Interval = 20;
            EnemyTimer.Start();
            NowPlay = true;
            Dead = false;
        }

        private void PlayHard_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gravity = 3;
            RunSpeed = 15;
            GameMode = 8;
            this.ActiveControl = null;
            if (SoundMute == false)
            BackGroundSound.PlayLooping();
            GamePanel.Visible = false;
            PlayNormal.TabStop = false;
            Player.Image = Properties.Resources.BotWalk;
            EnemyTimer.Interval = 20;
            EnemyTimer.Start();
            NowPlay = true;
            Dead = false;
        }
        
        //
        //ANIMACE BUTTON
        //
        Image btn1 = Properties.Resources.Button1;
        Image btn2 = Properties.Resources.Button2;
        private void PlayEasy_MouseEnter(object sender, EventArgs e)
        {
            PlayEasy.BackgroundImage = btn2;
        }

        private void PlayEasy_MouseLeave(object sender, EventArgs e)
        {
            PlayEasy.BackgroundImage = btn1;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (SoundMute == false)
            {
                SoundMute = true;
                btnMute.Image = Properties.Resources.SoundOff;
            }
            else
            {
                SoundMute = false;
                btnMute.Image = Properties.Resources.SoundOn;
            }    
        }

        private void PlayGround_SizeChanged(object sender, EventArgs e)
        {
            poleMonitorLive.Left = this.Width - (174 + 30);
            poleMonitorCoin.Left = this.Width - (174 * 2) - 30 - 10;
            zobrazeniCoin.Left = this.Width - (174 * 2);

            GamePanel.Left = (this.Width / 2) - (GamePanel.Width / 2);
            GamePanel.Top = (this.Height / 2) - (GamePanel.Width / 2);

            DownGround.Width = this.Width;
            DownGround.Height = this.Height;
        }

        private void PlayNormal_MouseEnter(object sender, EventArgs e)
        {
            PlayNormal.BackgroundImage = btn2;
        }

        private void PlayNormal_MouseLeave(object sender, EventArgs e)
        {
            PlayNormal.BackgroundImage = btn1;
        }

        private void PlayHard_MouseEnter(object sender, EventArgs e)
        {
            PlayHard.BackgroundImage = btn2;
        }

        private void PlayHard_MouseLeave(object sender, EventArgs e)
        {
            PlayHard.BackgroundImage = btn1;
        }

        private void LostFokus_Enter(object sender, EventArgs e)
        {
            zobrazeniCoin.Focus();
        }

        // ukončovací závorky
    }
}
