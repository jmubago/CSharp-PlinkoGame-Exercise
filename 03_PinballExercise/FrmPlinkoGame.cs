using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PinballExercise
{
    public partial class FrmPlinkoGame : Form
    {
        public FrmPlinkoGame()
        {
            InitializeComponent();
        }


        //Play Plinko game and calculate after 1000 games how many times
        //the ball falls on each number
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] ballPosition = new int[10];

            for (int x = 1; x <= 1000; x++)
            {
                //Calculate where the ball will fall each time
                double pos = 5;
                for (int i = 1; i <= 8; i++)
                {
                    int move = r.Next(1, 3);
                    if (move == 1)
                    {
                        pos += 0.5;
                    }
                    else
                    {
                        pos -= 0.5;
                    }
                }
                //int intPos = Convert.ToInt32(pos);
                int intPos = (int)pos;
                ballPosition[intPos] += 1;
            }

            //Display results on TextBox
            TxtResult01.Text = ballPosition[1].ToString();
            TxtResult02.Text = ballPosition[2].ToString();
            TxtResult03.Text = ballPosition[3].ToString();
            TxtResult04.Text = ballPosition[4].ToString();
            TxtResult05.Text = ballPosition[5].ToString();
            TxtResult06.Text = ballPosition[6].ToString();
            TxtResult07.Text = ballPosition[7].ToString();
            TxtResult08.Text = ballPosition[8].ToString();
            TxtResult09.Text = ballPosition[9].ToString();
        }
    }
}
