using System;
using System.Drawing;
using System.Windows.Forms;

namespace Damka
{
    public partial class fDamka : Form
    {
        public int xCoordinate, yCoordinate, wid, hit, x1, y1, x2, y2, Timepick = 0, CountError = 0;
        public bool isError = false, isActivated = true, isBlue = true, isEaten = false, isAbleEat = false;
        public int[,] Soilders = new int[10, 10], Clicks;
        public bool[,] Retangle = new bool[8, 8];
        

        public fDamka()
        {
            InitializeComponent();
        }

        private void PbStartscreen_Paint(object sender, PaintEventArgs e)
        {

            if (isActivated)
            {
                pbStartscreen.Size = new Size(wid, hit);
            }
            int Wd = pbStartscreen.ClientRectangle.Width, Ht = pbStartscreen.ClientRectangle.Height, k, i, CountRed = 0, CountBlue = 0;
            float xScale = (float)(Wd / 100.0), yScale = (float)(Ht / 100.0);
            int wdForm = Wd / 8, htForm = Ht / 8, xCell, yCell;
            Pen Lpen = new Pen(Color.Black, 1);
            SolidBrush RBrush = new SolidBrush(Color.SeaGreen);
            SolidBrush Brush = new SolidBrush(Color.Black);
            SolidBrush BBrush = new SolidBrush(Color.GreenYellow);
            SolidBrush GBrush = new SolidBrush(Color.Gold);
            SolidBrush WBrush = new SolidBrush(Color.White);
            SolidBrush BRBrush = new SolidBrush(Color.Brown);
            SolidBrush RBBrush = new SolidBrush(Color.RosyBrown);

           
            


            Font foont = new Font("Ariel", 40);
            Point point = new Point((int)(20 * xScale), (int)(50 * yScale));
            DateTime Tthen = DateTime.Now;



            //Line draw
            for (int x = 1; x <= 7; x += 1)
            {
                e.Graphics.DrawLine(Lpen, wdForm * x, 0, wdForm * x, 100 * yScale);
            }
            for (int y = 1; y <= 7; y += 1)
            {
                e.Graphics.DrawLine(Lpen, 0, htForm * y, 100 * xScale, htForm * y);
            }

            for (i = 1; i <= 8; i++)
            {
                for (k = 1; k <= 8; k++)
                {
                    if((i + k) % 2 == 0)
                        e.Graphics.FillRectangle(BRBrush,(k -1) * wdForm,(i - 1 ) * htForm,wdForm,htForm);
                    else
                        e.Graphics.FillRectangle(RBBrush, (k - 1) * wdForm, (i - 1) * htForm, wdForm, htForm);
                }
            }



            //Reseting the array
            if (isActivated)
            {
                for (i = 1; i < 9; i++)
                {
                    for (k = 1; k < 9; k++)
                    {
                        if ((i + k) % 2 == 0)
                        {
                            if (i <= 3)
                                Soilders[i, k] = 1;
                            if (i >= 6)
                                Soilders[i, k] = 2;
                        }
                        else
                            Soilders[i, k] = 0;
                    }
                }
                isActivated = false;
            }
            
            //distace
            xCell = xCoordinate / wdForm + 1;
            yCell = yCoordinate / htForm + 1;


            Clicks = Soilders;

            //Turns
            if (Timepick == 1)
            {
                if (Soilders[yCell, xCell] != 0)
                {
                    y1 = yCell;
                    x1 = xCell;
                }
                else
                    Timepick--;
            }
            else
            {
                if (Timepick == 2)
                {
                    y2 = yCell;
                    x2 = xCell;
                    isEaten = DamkaProp.IsEat(Soilders, x1, y1, x2, y2, isBlue);
                    isError = DamkaProp.ErrorCheck(Soilders,x1,y1,x2,y2,isBlue,isEaten,isAbleEat);
                    if (!isError)
                    {
                        isAbleEat = DamkaProp.isAbleEat(Soilders, x2, y2, isBlue);
                        Soilders = DamkaProp.DrawDamka(Soilders, isBlue, x1, y1, x2, y2,isEaten);
                        isBlue = !isBlue;
                    }
                    Timepick = 0;

                    /*if (isAbleEat && isEaten)
                    {
                        if (!isError)
                        {
                            Timepick = 0; 
                        }

                    }*/
                }
            }

            DamkaProp.MakeKings(ref Soilders);

            if (Soilders == Clicks)
                CountError++;
            for (i = 1; i <= 8; i++)
            {
                for (k = 1; k <= 8; k++)
                {
                    switch (Soilders[i, k])
                    {
                        case 1: case 3:
                            CountRed++;
                            break;
                        case 2: case 4:
                            CountBlue++;
                            break;
                    }
                    if (Soilders[i, k] == 1)
                        e.Graphics.FillEllipse(RBrush, (k - 1) * wdForm +3 , (i - 1) * htForm + 3 , htForm -5, htForm -5);
                    if (Soilders[i, k] == 3)
                    {
                        e.Graphics.FillEllipse(RBrush, (k - 1) * wdForm + 3, (i - 1) * htForm + 3, htForm - 5, htForm - 5);
                        e.Graphics.FillEllipse(GBrush, (k - 1) * wdForm + wdForm / 4, (i - 1) * htForm + htForm / 4, wdForm / 2, htForm / 2);
                    }
                    if (Soilders[i, k] == 2)
                        e.Graphics.FillEllipse(BBrush, (k - 1) * wdForm + 3 , (i - 1) * htForm + 3, htForm - 5, htForm - 5);
                    if (Soilders[i, k] == 4)
                    {
                        e.Graphics.FillEllipse(BBrush, (k - 1) * wdForm + 3, (i - 1) * htForm + 3, htForm - 5, htForm - 5);
                        e.Graphics.FillEllipse(GBrush, (k - 1) * wdForm + wdForm/4, (i - 1) * htForm + htForm /4, wdForm / 2, htForm / 2);
                    }
                }
            }
            if (CountBlue == 0)
            {
                
                do
                {
                    Application.DoEvents();
                    e.Graphics.FillRectangle(WBrush, 0, 0, Wd, Ht);
                    e.Graphics.DrawString("R E D   I S   T H E   W I N N E R", foont, new SolidBrush(Color.Red), 30 * xScale, 30 * yScale);
                }
                while (Tthen.AddSeconds(5) > DateTime.Now);

                Application.Exit();
            }

            if (CountRed == 0)
            {
                do
                {
                    Application.DoEvents();
                    e.Graphics.FillRectangle(WBrush, 0, 0, Wd, Ht);
                    e.Graphics.DrawString("B L U E   I S   T H E   W I N N E R", foont, new SolidBrush(Color.Blue), 30 * xScale, 30 * yScale);
                } while (Tthen.AddSeconds(5) > DateTime.Now);
                Application.Exit();
            }
            if (isBlue)
            {
                e.Graphics.FillRectangle(BBrush, 1 * xScale, 1 * yScale,20, 20);
                e.Graphics.DrawRectangle(Lpen, 1 * xScale, 1 * yScale, 20, 20);
            }
            else
            {
                e.Graphics.FillRectangle(RBrush, 1* xScale, 1 * yScale, 20, 20);
                e.Graphics.DrawRectangle(Lpen, 1 * xScale, 1 * yScale, 20,20);
            }

            if(CountError == 4)
            {
                CountError = 0;
                Timepick = 0;
            }
            
        }
        private void fDamka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fDamka_Paint(object sender, PaintEventArgs e)
        {
            wid = e.ClipRectangle.Width;
            hit = e.ClipRectangle.Height;
        }

        private void fDamka_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int ESCAPE = 27;
            if (e.KeyChar == ESCAPE)
                Application.Exit();
        }


        private void fDamka_Load_1(object sender, EventArgs e)
        {
            
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
           
        }

        private void pbStartscreen_MouseClick(object sender, MouseEventArgs e)
        {
            xCoordinate = e.Location.X;
            yCoordinate = e.Location.Y;
            Timepick++;
            pbStartscreen.Refresh();
        }
    }
}
