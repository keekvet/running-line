using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitOperations
{
    public partial class Form1 : Form
    {
        Field field;
        Color[,] backCol;
        int letterCounter = 0, columnCounter = 0;
        String txtToShow;
        public Form1()
        {
            InitializeComponent();
            field = new Field();
            backCol = new Color[64, 8];
            for (int i = 0; i < 64; i++)
            {
                for (int y = 0; y < 8; y++)
                {
                    backCol[i, y] = Color.Black;
                }

            }
        }
        private void PixelDisp_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (SolidBrush sb = new SolidBrush(backCol[e.Column, e.Row]))
            {
                e.Graphics.FillRectangle(sb, e.CellBounds);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtToShow = textBox.Text;
            timer1.Interval = (int)numInterval.Value;
            timer1.Start();
        }

        void Display() {
            long mask = 1;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(Convert.ToString(field.fieldLines[i], 2).PadLeft(64, '0'));
                for (int y = 63; y >= 0; y--)
                {
                    if ((field.fieldLines[i] & mask) == mask)
                        backCol[y, i] = Color.Red;
                    else
                        backCol[y, i] = Color.Black;
                    
                    mask <<= 1;
                }
                mask = 1;
            }
            pixelDisp.Refresh();
        }

        private void StopBtm_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void CleanBtm_Click(object sender, EventArgs e)
        {
            field.Сlean();
            Display();
        }

        private void RestartBtm_Click(object sender, EventArgs e)
        {
            field.Сlean();
            Display();
            columnCounter = 0;
            letterCounter = 0;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            field.AddColumn(new Character(txtToShow.ElementAt(letterCounter)), columnCounter);
            Display();
            columnCounter++;
            if (columnCounter == 8)
            {
                if (txtToShow.Length == letterCounter + 1)
                {
                    columnCounter = 0;
                    letterCounter = -1;
                }
                columnCounter = 0;
                letterCounter++;
            }
        }
    }
}
