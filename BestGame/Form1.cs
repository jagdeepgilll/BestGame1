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

namespace BestGame
{
    public partial class Form1 : Form
    {
        int Aways = 3;
        int GunShot = 0;
        int autho = 1;
        int unautho = 0;
        int plr = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Spin_Click(object sender, EventArgs e)

        {
            if (unautho == 1)
            {
                SpinGun();
                autho = 0;
            }
        }

        public void SpinGun()
            //Spin the gun after loading
        {
           
                Random spins = new Random();
                Aways = spins.Next(0, 6);
            // Messsage shows that spin is done
                MessageBox.Show("Spin Done");
         
        }

        private void Away_Click_2(object sender, EventArgs e)
        {
            AwayGun();            
        }
        // Shot the gun away
        public void AwayGun()
           
        {
            if (autho == 0)

            {

                if (Aways > 0 && Aways == 3)
                {
                    if (plr == 0)
                        // show the message of chance of shot away 
                    {
                        MessageBox.Show("You shot away more than 2 Game Over!!");
                    }
                    else
                    {
                        
                        SoundPlayer Sp = new SoundPlayer(BestGame.Properties.Resources.Mss);
                        Sp.Play();                        
                        plr = plr -1;
                        MessageBox.Show("Away Shot \n" + GunShot + "\n");
                    }
                }

            }
        }

        private void Shoot_Click_1(object sender, EventArgs e)
        {
            
            ShootGun();
            
        }
        //shoot the gun when loaded

        public void ShootGun()
        {
            if (autho == 0)

            {

                if (GunShot >= 6)
                    //Message shows the game is finish
                {
                    MessageBox.Show("Game Over ! You Get 6 Points Congratulations");
                }
                else
                {
                    //Play shot sound
                    SoundPlayer Sp = new SoundPlayer(BestGame.Properties.Resources.gg);
                    Sp.Play();
                    Aways = Aways = 3;
                    GunShot = GunShot + 1;
                    MessageBox.Show("Got Point \n " + GunShot + "\n");
                }
            }
        }

        private void Relaod_Click_1(object sender, EventArgs e)
        {
            // load the bullets in gun
            {
                ReloadGun();
                
            }
        }

        public void ReloadGun()
           
        {
            
                               
                {
                    GunShot = 0;
                    
                    unautho = 1;
                //play reload sound
                    SoundPlayer Sp = new SoundPlayer(BestGame.Properties.Resources._1608137108951);
                    Sp.Play();
                //Show the message when gun is loaded
                    MessageBox.Show("Gun Reload Now!");
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
