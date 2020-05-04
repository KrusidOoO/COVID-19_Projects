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

        public int totalEnemies = 5;
        public Form1()
        {
            InitializeComponent();
        }

        Movement movement = new Movement();
        Bullets bullets = new Bullets();
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
            if(e.KeyCode==Keys.Left)
            {
                movement.goleft = false;
            }
            else if(e.KeyCode==Keys.Right)
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
        }

        private void MakeBullet()
        {
            PictureBox bullet=new PictureBox();
            bullet.Image = Properties.Resources.Bullet;
            bullets.makeBullet(SpaceShip.Left,SpaceShip.Width,SpaceShip.Top,bullet);
            this.Controls.Add(bullet);
        }

        private void GameOver()
        {
            Timer.Stop();
            label1.Text += "  Game Over";
        }
    }
}
