using SpaceInvaders.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        Movement movement = new Movement();
        Bullets bullets = new Bullets();
        Score score = new Score();

        public int totalEnemies = 5;
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyDownPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                movement.goleft = true;
            }
            else if(e.KeyCode==Keys.Right)
            {
                movement.goright = true;
            }

            if(e.KeyCode==Keys.Space&&!movement.isPressed)
            {
                movement.isPressed = true;
                MakeBullet();
            }
        }

        private void KeyUpPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left||e.KeyCode==Keys.A)
            {
                movement.goleft = false;
            }
            else if(e.KeyCode==Keys.Right||e.KeyCode==Keys.D)
            {
                movement.goright = false;
            }

            if(movement.isPressed)
            {
                movement.isPressed = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(movement.goleft)
            {
                SpaceShip.Left -= movement.playerSpeed;
            }
            else if(movement.goright)
            {
                SpaceShip.Left += movement.playerSpeed;
            }

            #region Enemies moving
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Alien")
                {
                    if(((PictureBox)x).Bounds.IntersectsWith(SpaceShip.Bounds))
                    {
                        GameOver();
                    }
                    ((PictureBox)x).Left += movement.speed;
                    if(((PictureBox)x).Left>900)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 10;
                        ((PictureBox)x).Left = -50;
                    }
                }
            }
            #endregion

            #region Bullet movemenet
            foreach (Control y in this.Controls)
            {
                if(y is PictureBox &&y.Tag=="Bullet")
                {
                    y.Top -= 20;
                    if(((PictureBox)y).Top<this.Height-740)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox &&x.Tag=="Enemy Bullet")
                {
                    x.Top += 20;
                    if(((PictureBox)x).Top>this.Height-10)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
            #endregion
            
            #region Bullet & Collision
            foreach (Control i in this.Controls)
            {
                foreach(Control j in this.Controls)
                {
                    if(i is PictureBox&&i.Tag=="Alien")
                    {
                        if(j is PictureBox&&j.Tag=="Bullet")
                        {
                            if(i.Bounds.IntersectsWith(j.Bounds))
                            {
                                score.score+=10;
                                totalEnemies--;
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                            }
                        }
                    }
                }
            }
            foreach(Control k in this.Controls)
            {
                foreach(Control l in this.Controls)
                {
                    if(k is PictureBox&&k.Tag=="Player")
                    {
                        if(l is PictureBox&&l.Tag=="Enemy Bullet")
                        {
                            if(k.Bounds.IntersectsWith(l.Bounds))
                            {
                                this.Controls.Remove(k);
                                this.Controls.Remove(l);
                                GameOver();
                            }
                        }

                    }
                }
            }
            EnemyBullet(true);
            #endregion

            label1.Text = "Score: " + score.score;

            if(totalEnemies<=0)
            {
                GameOver();
                MessageBox.Show("You killed all the aliens!\nGreat job soldier");
                Application.Exit();
            }
        }

        private void MakeBullet()
        {
            PictureBox bullet=new PictureBox();
            bullet.Image = Properties.Resources.Bullet;
            bullets.makeBullet(SpaceShip.Left,SpaceShip.Width,SpaceShip.Top,bullet);
            this.Controls.Add(bullet);
        }

        private void EnemyBullet(bool Alive)
        {
            PictureBox EnemyBullet = new PictureBox();
            EnemyBullet.Image = Properties.Resources.Bullet;
            bullets.EnemyMakeBullet(Alien1.Left, Alien1.Width, Alien1.Top, EnemyBullet);
            this.Controls.Add(EnemyBullet);
        }

        private void GameOver()
        {
            Timer.Stop();

            if(totalEnemies>0)
            label1.Text += "  Game Over";
        }
    }
}
