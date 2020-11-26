using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gamespeed);
            Enemy(gamespeed + 1);
            GameOver();
            Coins(gamespeed);
            CoinCollection();
        }

        void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = -109;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = -109;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = -109;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = -109;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int gamespeed = 1;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                {
                    car.Left += -30;
                }
                
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Left < 330)
                {
                    car.Left += 30;
                }

            }

                if (e.KeyCode == Keys.Up)
                {
                    if (gamespeed < 21)
                    {
                        gamespeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                        if (gamespeed > 0)
                        {
                            gamespeed--;
                        }
                    
                    
                }
               
            
        }

        Random r = new Random();
        int x;
        void Enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 150);
                enemy1.Location = new Point(x, -20);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(170, 210);
                enemy2.Location = new Point(x, -20);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(220 , 320);
                enemy3.Location = new Point(x, -20);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void Coins(int speed)
        {
            if (gold1.Top >= 500)
            {
                x = r.Next(0, 320);
                gold1.Location = new Point(x, -20);
            }
            else
            {
                gold1.Top += speed;
            }

            if (bronze1.Top >= 500)
            {
                x = r.Next(0, 320);
                bronze1.Location = new Point(x, -20);
            }
            else
            {
                bronze1.Top += speed;
            }

            if (bronze2.Top >= 500)
            {
                x = r.Next(0, 320);
                bronze2.Location = new Point(x, -20);
            }
            else
            {
                bronze2.Top += speed;
            }

            if (silver1.Top >= 500)
            {
                x = r.Next(0, 320);
                silver1.Location = new Point(x, -20);
            }
            else
            {
                silver1.Top += speed;
            }

            if (silver2.Top >= 500)
            {
                x = r.Next(0, 320);
                silver2.Location = new Point(x, -20);
            }
            else
            {
                silver2.Top += speed;
            }
        }


        int collectedCoin = 0;
        
        void CoinCollection()
        {
            if (car.Bounds.IntersectsWith(gold1.Bounds))
            {
                collectedCoin += 5;
                score.Text = "Score=" + collectedCoin.ToString();
                x = r.Next(0, 320);
                gold1.Location = new Point(x, -20);
            }

            if (car.Bounds.IntersectsWith(silver1.Bounds))
            {
                collectedCoin += 3;
                score.Text = "Score=" + collectedCoin.ToString();
                x = r.Next(0, 320);
                silver1.Location = new Point(x, -20);
            }

            if (car.Bounds.IntersectsWith(silver2.Bounds))
            {
                collectedCoin += 3;
                score.Text = "Score=" + collectedCoin.ToString();
                x = r.Next(0, 320);
                silver2.Location = new Point(x, -20);
            }

            if (car.Bounds.IntersectsWith(bronze1.Bounds))
            {
                collectedCoin += 1;
                score.Text = "Score=" + collectedCoin.ToString();
                x = r.Next(0, 320);
                bronze1.Location = new Point(x, -20);
            }

            if (car.Bounds.IntersectsWith(bronze2.Bounds))
            {
                collectedCoin += 1;
                score.Text = "Score=" + collectedCoin.ToString();
                x = r.Next(0, 320);
                bronze2.Location = new Point(x, -20);
            }
        }
 
            void GameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                
                
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                

            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
                    }
    }
}
