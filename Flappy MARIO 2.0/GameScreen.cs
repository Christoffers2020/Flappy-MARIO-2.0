using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_MARIO_2._0
{
    public partial class GameScreen : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown, gameOver;

        string facing = "right";
        int pipeSpeed = 12;
       // int gravity = -1;
        int score = 0;
        int enemySpeed = 10;

        private List<PictureBox> enemyList = new List<PictureBox>();


        public GameScreen()
        {
            InitializeComponent();
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (marioBox.Left > 0)
            {
                marioBox.Left -= 1;
            }
        //    if  (moveRight == true && marioBox.Right > 0)
          //  {
         //       marioBox.Location = new Point(marioBox.Location.X + 1000,marioBox.Location.Y);
           // }

            if (moveUp == true && marioBox.Up > 0)
            {
                
            }


            Fireball1.Left -= pipeSpeed;
            Fireball2.Left -= pipeSpeed;
            fireball3.Left -= pipeSpeed;
            Fireball4.Left -= pipeSpeed;

            if (Fireball1.Left < -50)
            {
                Fireball1.Left = 800;
            }

            if (Fireball2.Left < -50)
            {
                Fireball2.Left = 850;
            }

            if (fireball3.Left < -50)
            {
                fireball3.Left = 900;
            }

            if (Fireball4.Left < -50)
            {
                Fireball4.Left = 950;
            }
        }

        private void scoreBoard_Click(object sender, EventArgs e)
        {

        }

        private void keyISdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
                facing = "right";

            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
                facing = "right";
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
                facing = "right";
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
                facing = "right";
            }
        }

        private void keyISup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
                facing = "right";
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
                facing = "right";
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
                facing = "right";
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
                facing = "right";
            }

            if (e.KeyCode == Keys.Space)
            {
       //         Shootfire();
            }
        }

        private void Shootfire(string direction)
        {

        }

        private void MakeEnemy()
        {

        }

        private void RestartGame()
        {

        }

    }
}


