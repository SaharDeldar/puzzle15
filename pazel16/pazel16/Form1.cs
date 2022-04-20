using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pazel16
{
    public partial class Form1 : Form
    {
        Button[,]cells;
        int em_x,emt_y,  conter;
        public Form1()
        {
            InitializeComponent();
            cells = new Button[4, 4] { { button1, button2, button3, button4 },
                                        {button5,button6 ,button7,button8 },
                                        { button9,button10,button11,button12 },
                                        { button13,button14,button15,button16} };

            Random r = new Random();
            int[] a = new int[16];
            for (int i = 0; i < 16; i++)
            {
                while (true)
                {
                    int x = r.Next(1, 17);
                    if (!a.Contains(x))
                    {
                        a[i] = x;
                        break;
                    }
                }
            }

            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[index] == 16)
                    {
                        cells[i, j].Hide();
                        em_x = i;
                        emt_y = j;
                    }
                    cells[i, j].Text = Convert.ToString(a[index]);
                    cells[i, j].Font = new Font("Arial", 20);
                    index++;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

            DialogResult iExit = MessageBox.Show("confrim if you want to exit ", "shuffle Game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)

            {
                Application.ExitThread();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = Convert.ToString(16);
            solutioncheckr();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("confrim if you want to exit ", "shuffle Game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(iExit ==DialogResult.No)

                {
                e.Cancel = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Hide();
            Form1 newgame = new Form1();
            newgame.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button this_button = sender as Button;
            int x=0, y=0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(cells[i,j]==this_button)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            if(
                (x==em_x&&(y==emt_y-1 ||y== emt_y + 1))
                ||
                    (y==emt_y&&(x==em_x-1 || x == em_x + 1)))
                {
                cells[em_x, emt_y].Text = this_button.Text;
                this_button.Text = "16";
                cells[em_x, emt_y].Show();
                this_button.Hide();
                em_x = x;
                emt_y = y;
            }


        }
     
        public void solutioncheckr()
        {
            if(button1.Text=="1"&& button2.Text == "2" && button3.Text == "3" && button4.Text == "4" 
                && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" 
                && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" 
                && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" )
            {
                MessageBox.Show("well done you are winner", "shuffle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
