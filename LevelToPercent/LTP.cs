/*
Created by: Matthew Brean
Created on: 2015-11-03
Created for: ICS3U
Daily Assignment: Unit #4-04
This program converts level mark to percentage mark.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelToPercent
{
    public partial class frmLTP : Form

    {

        public int MarkCalculator (string levelMark)
        {
            //this function converts level mark to percentage mark
            int PercentageMark;

            if (levelMark == "4+")
            {
                PercentageMark = 95;
            }
            else if (levelMark == "4")
            {
                PercentageMark = 90;
            }
            else if (levelMark == "4-")
            {
                PercentageMark = 85;
            }
            else if (levelMark == "3+")
            {
                PercentageMark = 77;
            }
            else if (levelMark == "3")
            {
                PercentageMark = 75;
            }
            else if (levelMark == "3-")
            {
                PercentageMark = 72;
            }
            else if (levelMark == "2+")
            {
                PercentageMark = 67;
            }
            else if (levelMark == "2")
            {
                PercentageMark = 65;
            }
            else if (levelMark == "2-")
            {
                PercentageMark = 62;
            }
            else if (levelMark == "1+")
            {
                PercentageMark = 57;
            }
            else if (levelMark == "1")
            {
                PercentageMark = 55;
            }
            else if (levelMark == "1-")
            {
                PercentageMark = 52;
            }
            else if (levelMark == "R")
            {
                PercentageMark = 30;
            }
            else if (levelMark == "NE")
            {
                PercentageMark = 0;
            }

            else PercentageMark = -1;  

            return PercentageMark;
        }


        public frmLTP()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables
            string levelMark = this.txtLevel.Text;
            int percentageMark;

           percentageMark = MarkCalculator(levelMark);
            this.lblPercent.Text = "Your mark is: " + percentageMark;
            
        }
    }
}
