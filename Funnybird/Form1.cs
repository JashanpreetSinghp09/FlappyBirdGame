using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funnybird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int gravity_pull = 10;
        private int speed = 18;
        private int score = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity_pull = -10;
            }else if(e.KeyCode == Keys.Enter)
            {
                timer1.Start();
            }

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity_pull = 10;
            }
        }
        Random r = new Random();
        private void Gametimer(object sender, EventArgs e)
        {
            bird.Top += gravity_pull;
            pipedown.Left -= speed;
            
            pipeup.Left -= speed;
           
            Score.Text = $"Score: {score}";

            if (pipedown.Left < -323)
            {
                pipedown.Left = r.Next(100, 700);
                score++;
            }if(pipeup.Left < -323)
            {
                pipeup.Left = r.Next(300, 700);
                score++;
            }if(bird.Bounds.IntersectsWith(pipeup.Bounds)|| bird.Bounds.IntersectsWith(pipedown.Bounds)|| bird.Bounds.IntersectsWith(ground.Bounds))
                
            {
                timer1.Stop();
                Score.Text += "    Oppps!! GAME OVER :(";
            }if(score > 10)
            {
                speed += 1;
                
            }
        }
    }
}
