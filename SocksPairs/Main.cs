using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocksPairs
{
    public partial class Main : Form
    {
        public int red, green, yellow, purple, blue, pink, orange;
        public Main()
        {
            InitializeComponent();
        }
        public void shrabhide()
        {
            blue1.Hide(); blue2.Hide(); blue3.Hide(); blue4.Hide(); blue5.Hide();
            yellow1.Hide(); yellow2.Hide(); yellow3.Hide(); yellow4.Hide(); yellow5.Hide();
            green1.Hide(); green2.Hide(); green3.Hide(); green4.Hide(); green5.Hide();
            red1.Hide(); red2.Hide(); red3.Hide(); red4.Hide(); red5.Hide();
            purple1.Hide(); purple2.Hide(); purple3.Hide(); purple4.Hide(); purple5.Hide();
            pink1.Hide(); pink2.Hide(); pink3.Hide(); pink4.Hide(); pink5.Hide();
            orange1.Hide(); orange2.Hide(); orange3.Hide(); orange4.Hide(); orange5.Hide();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            picrot.Hide();
            shrabhide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picrot.Show();
        }

        private void orangetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void greentxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void redtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bluetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void redmbtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(redtxtbox.Text)==0)
            {
                redtxtbox.Text = 0+"";
            }
            else
            {
                int h = int.Parse(redtxtbox.Text);
                h--;
                redtxtbox.Text = h+"";
            }
        }

        private void orangembtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(orangetxtbox.Text) == 0)
            {
                orangetxtbox.Text = 0 + "";
            }
            else
            {
                int h = int.Parse(orangetxtbox.Text);
                h--;
                orangetxtbox.Text = h + "";
            }
        }

        private void greenmbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(greentxtbox.Text) == 0)
            {
                greentxtbox.Text = 0 + "";
            }
            else
            {
                int h = int.Parse(greentxtbox.Text);
                h--;
                greentxtbox.Text = h + "";
            }
        }

        private void bluembtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(bluetxtbox.Text) == 0)
            {
                bluetxtbox.Text = 0 + "";
            }
            else
            {
                int h = int.Parse(bluetxtbox.Text);
                h--;
                bluetxtbox.Text = h + "";
            }
        }

        private void pinkmbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(pinktxtbox.Text) == 0)
            {
                pinktxtbox.Text = 0 + "";
            }
            else
            {
                int h = int.Parse(pinktxtbox.Text);
                h--;
                pinktxtbox.Text = h + "";
            }
        }

        private void yellowmbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(yellowtxtbox.Text) == 0)
            {
                yellowtxtbox.Text = 0 + "";
            }
            else
            {
                int h = int.Parse(yellowtxtbox.Text);
                h--;
                yellowtxtbox.Text = h + "";
            }
        }

        private void purplembtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(purpletxtbox.Text) == 0)
            {
                purpletxtbox.Text = 0 + "";
            }
            else
            {
                int h = int.Parse(purpletxtbox.Text);
                h--;
                purpletxtbox.Text = h + "";
            }
        }

        private void purplepbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(purpletxtbox.Text) > 9)
            {
                purpletxtbox.Text = 10 + "";
            }
            else
            {
                int h = int.Parse(purpletxtbox.Text);
                h++;
                purpletxtbox.Text = h + "";
            }
        }

        private void yellowpbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(yellowtxtbox.Text) > 9)
            {
                yellowtxtbox.Text = 10 + "";
            }
            else
            {

                int h = int.Parse(yellowtxtbox.Text);
                h++;
                yellowtxtbox.Text = h + "";
            }
        }

        private void pinkpbtn_Click(object sender, EventArgs e)
        {

            if (int.Parse(pinktxtbox.Text) > 9)
            {
                pinktxtbox.Text = 10 + "";
            }
            else
            {
                int h = int.Parse(pinktxtbox.Text);
                h++;
                pinktxtbox.Text = h + "";
            }
        }

        private void bluepbtn_Click(object sender, EventArgs e)
        {

            if (int.Parse(bluetxtbox.Text) > 9)
            {
                bluetxtbox.Text = 10 + "";
            }
            else
            {
                int h = int.Parse(bluetxtbox.Text);
                h++;
                bluetxtbox.Text = h + "";
            }
        }

        private void greenpbtn_Click(object sender, EventArgs e)
        {

            if (int.Parse(greentxtbox.Text) > 9)
            {
                greentxtbox.Text = 10 + "";
            }
            else
            {
                int h = int.Parse(greentxtbox.Text);
                h++;
                greentxtbox.Text = h + "";
            }
        }

        private void orangepbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(orangetxtbox.Text) > 9)
            {
                orangetxtbox.Text = 10 + "";
            }
            else
            {
                int h = int.Parse(orangetxtbox.Text);
                h++;
                orangetxtbox.Text = h + "";
            }
        }

        private void redpbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(redtxtbox.Text) > 9)
            {
                redtxtbox.Text = 10 + "";
            }
            else
            {
                int h = int.Parse(redtxtbox.Text);
                h++;
                redtxtbox.Text = h + "";
            }
        }
        public void hidee()
        {
            picrot.Hide(); button1.Hide(); button2.Hide(); pictureBox1.Hide();
            redmbtn.Hide(); redpbtn.Hide(); redtxtbox.Hide();
            bluembtn.Hide(); bluepbtn.Hide(); bluetxtbox.Hide();
            yellowmbtn.Hide(); yellowpbtn.Hide(); yellowtxtbox.Hide();
            greenmbtn.Hide(); greenpbtn.Hide(); greentxtbox.Hide();
            purplembtn.Hide(); purplepbtn.Hide(); purpletxtbox.Hide();
            orangembtn.Hide(); orangepbtn.Hide(); orangetxtbox.Hide();
            pinkmbtn.Hide(); pinkpbtn.Hide(); pinktxtbox.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        public void calc()
        {
             red = int.Parse(redtxtbox.Text);
             blue = int.Parse(bluetxtbox.Text);
             yellow = int.Parse(yellowtxtbox.Text);
             green = int.Parse(greentxtbox.Text);
             purple = int.Parse(purpletxtbox.Text);
             orange = int.Parse(orangetxtbox.Text);
             pink = int.Parse(pinktxtbox.Text);
             red /= 2; blue /= 2; yellow /= 2; green /= 2; purple /= 2; orange /= 2; pink /= 2;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            hidee();
            calc();
            switch (red)
            {
                case 1:
                    red1.Show();
                    break;
                case 2:
                    red2.Show();
                    break;
                case 3:
                    red3.Show();
                    break;
                case 4:
                    red4.Show();
                    break;
                case 5:
                    red5.Show();
                    break;
            }
            switch (green)
            {
                case 1:
                    green1.Show();
                    break;
                case 2:
                    green2.Show();
                    break;
                case 3:
                    green3.Show();
                    break;
                case 4:
                    green4.Show();
                    break;
                case 5:
                    green5.Show();
                    break;
            }
            switch (yellow)
            {
                case 1:
                    yellow1.Show();
                    break;
                case 2:
                    yellow2.Show();
                    break;
                case 3:
                    yellow3.Show();
                    break;
                case 4:
                    yellow4.Show();
                    break;
                case 5:
                    yellow5.Show();
                    break;
            }
            switch (pink)
            {
                case 1:
                    pink1.Show();
                    break;
                case 2:
                    pink2.Show();
                    break;
                case 3:
                    pink3.Show();
                    break;
                case 4:
                    pink4.Show();
                    break;
                case 5:
                    pink5.Show();
                    break;
            }
            switch (blue)
            {
                case 1:
                    blue1.Show();
                    break;
                case 2:
                    blue2.Show();
                    break;
                case 3:
                    blue3.Show();
                    break;
                case 4:
                    blue4.Show();
                    break;
                case 5:
                    blue5.Show();
                    break;
            }
            switch (purple)
            {
                case 1:
                    purple1.Show();
                    break;
                case 2:
                    purple2.Show();
                    break;
                case 3:
                    purple3.Show();
                    break;
                case 4:
                    purple4.Show();
                    break;
                case 5:
                    purple5.Show();
                    break;
            }
            switch (orange)
            {
                case 1:
                    orange1.Show();
                    break;
                case 2:
                    orange2.Show();
                    break;
                case 3:
                    orange3.Show();
                    break;
                case 4:
                    orange4.Show();
                    break;
                case 5:
                    orange5.Show();
                    break;
            }
        }
    }
}
