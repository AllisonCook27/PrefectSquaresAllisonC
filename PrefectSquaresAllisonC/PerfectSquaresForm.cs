/*
 * Created by: Allison Cook
 * Created on: 26 March, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Perfect Square
 * This program shows which numbers are perfect squares under the number input by the user
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

namespace PrefectSquaresAllisonC
{
    public partial class frmPrefectSquares : Form
    {
        public frmPrefectSquares()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when clicked
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables
            int value = 1, endingvalue, squareRootInt;
            double squareRootDouble;

            //clearing list
            lstPerfectsquare.Items.Clear();

            //get the users ending vaulr
            endingvalue = Convert.ToInt32(numNumber.Value);

            while (value <= endingvalue)
            {
                //take the square root of value
                squareRootDouble = Math.Sqrt(value);

                //convert the double to an int
                squareRootInt = Convert.ToInt32(squareRootDouble);

                //check to see if they are equal
                if (squareRootDouble == squareRootInt)
                {
                    //add to the list
                    lstPerfectsquare.Items.Add(value + " is a perfect sqaure");

                    //refresh
                    this.Refresh();
                }
                value++;
            }
            
        }

    }
}
