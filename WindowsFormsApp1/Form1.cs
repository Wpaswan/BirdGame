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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        SoundPlayer player=new SoundPlayer(@"E:\BirdGame\WindowsFormsApp1\Sound\wav.wav");
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            player.Play();
           

        }
        
        

       

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //FloppyBird.Top+=gravity;
            FloppyBird1.Top+=gravity;
            pipeBottom.Left -=pipeSpeed;
            pipeTop.Left -=pipeSpeed;
            House.Left -=pipeSpeed;
            pipebottom2.Left -=pipeSpeed;
            scoreText.Text ="Score:"+score;

           
            //FloppyBird1.Right+=pipeSpeed;
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                player.Play();
            }
            if(pipeTop.Left<-180)
            {
                pipeTop.Left =850;
                score++;
                player.Play();
            }
            if(House.Left<-50)
            {
                House.Left =900;
                score++;
            }
            if(FloppyBird1.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                FloppyBird1.Bounds.IntersectsWith(pipeTop.Bounds))
                {
                endGame();
            } 
            if(score>5)
            {
                pipeSpeed=15;
            }
            if(FloppyBird1.Top<-25)
            {
                endGame();
            }
            if(FloppyBird1.Bottom<-25)
            {
                endGame();
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
           
            player.Play();
            if (e.KeyCode == Keys.Space)
            {
                gravity=-15;
                

            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            
            player.Play();
            if (e.KeyCode==Keys.Space)
            {
                gravity=15;
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text +="Game Over!!!";
        }
    }
}
