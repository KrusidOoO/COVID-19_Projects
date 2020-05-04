using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Classes
{
    class Bullets
    {
        public void makeBullet(int bulletSpeedLeft,int bulletSpeedWidth, int bulletPos,PictureBox bullet)
        {
            
            bullet.Size = new Size(50, 50);

            bullet.SizeMode = PictureBoxSizeMode.StretchImage;

            bullet.Tag = ("Bullet");

            bullet.Left = bulletSpeedLeft+bulletSpeedWidth/2;

            bullet.Top = bulletPos;

            bullet.BringToFront();
        }
    }
}
