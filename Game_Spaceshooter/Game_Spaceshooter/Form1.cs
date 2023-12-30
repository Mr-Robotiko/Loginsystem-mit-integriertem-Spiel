using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Spaceshooter
{
    public partial class Form1 : Form
    {
        PictureBox[] stars;
        int backgroundspeed;
        int playerSpeed;
        Random rnd;

        PictureBox[] bullets;
        int bulletSpeed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //...speed ist die Geschwindigkeit der PictureBox bzw.
            //um wie viele Pixel sie sich beweget, wenn der Timer tickt
            backgroundspeed = 4;
            playerSpeed = 4;
            stars = new PictureBox[10];
            rnd = new Random();

            bullets = new PictureBox[3];
            bulletSpeed = 20;

            //Lädt die Bilder für die Geschosse
            Image bullet = Image.FromFile(@"asserts\munition.png");

            //Erstellt die Geschosse und fügt sie dem Form hinzu
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].Size = new Size(8, 8);
                bullets[i].Image = bullet;
                bullets[i].SizeMode = PictureBoxSizeMode.Zoom;
                bullets[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(bullets[i]);
            }

            //Erstellt die Sterne und fügt sie dem Form hinzu
            //Es gibt 10 Sterne, 5 kleine und 5 große, damit nicht alle gleich aussehen
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500), rnd.Next(-10, 400));
                if(i % 2 == 0)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.White;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
        }

        //Timer, der die Sterne bewegt und dafür sorgt, dass sie wieder nach oben kommen
        //Es gibt 2 verschiedene Geschwindigkeiten, damit es nicht so eintönig aussieht
        private void moveBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        //Timer, der den Spieler nach links bewegt
        private void moveLeftTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        //Timer, der den Spieler nach rechts bewegt
        private void moveRightTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Left < 460)
            {
                Player.Left += playerSpeed;
            }
        }

        //Timer, der den Spieler nach unten bewegt
        private void moveDownTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Top < 360)
            {
                Player.Top += playerSpeed;
            }
        }

        //Timer, der den Spieler nach oben bewegt
        private void moveUpTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        //Wenn eine Taste gedrückt wird, wird der entsprechende Timer gestartet
        //Der Spieler bewegt sich dann in die entsprechende Richtung
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                moveLeftTimer.Start();
            }

            if(e.KeyCode == Keys.D)
            {
                moveRightTimer.Start();
            }

            if (e.KeyCode == Keys.S)
            {
                moveDownTimer.Start();
            }

            if (e.KeyCode == Keys.W)
            {
                moveUpTimer.Start();
            }
        }

        //Wenn eine Taste losgelassen wird, wird der entsprechende Timer gestoppt
        //Der Spieler bewegt sich dann nicht mehr in die entsprechende Richtung
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                moveLeftTimer.Stop();
            }
            if(e.KeyCode == Keys.D)
            {
                moveRightTimer.Stop();
            }
            if(e.KeyCode == Keys.S)
            {
                moveDownTimer.Stop();
            }
            if(e.KeyCode == Keys.W)
            {
                moveUpTimer.Stop();
            }
        }

        //Timer, der die Geschosse bewegt
        private void moveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].Top > 0)
                {
                    bullets[i].Visible = true;
                    bullets[i].Top -= bulletSpeed;
                }
                else
                {
                    bullets[i].Visible = false;
                    bullets[i].Location = new Point(Player.Location.X + 20, Player.Location.Y);
                }
            }
        }
    }
}