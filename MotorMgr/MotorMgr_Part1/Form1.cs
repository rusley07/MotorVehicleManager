using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotorMgr
{
    public partial class mainForm : Form
    {
        // RB 9/5/13
        // Assignment
     
        public mainForm()
        {
            InitializeComponent();
        }

        private decimal totalVehiclesSold = 0;
        private decimal totalAmount = 0;
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please enter your phone number", "Phone Number");
                comboBox1.Focus();
                return;
            }

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please enter your name", "Name");
                comboBox2.Focus();
                return;
            }

            // disable customer name and phone text boxes, set fous to price text box
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            priceTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare variables
            decimal vehiclePrice = 0;
            decimal tradeInPrice = 0;
            decimal warVehCost = 0;
            decimal extrasCost = 0;
            decimal insuranceCost = 0;
            decimal subAmount = 0;
            decimal gstAmount = 0;
            decimal finalAmount = 0;
            decimal totalVehicles = 0;
           
          
            // input and validate vehicle price
            if (priceTextBox.Text == "")
            {
                MessageBox.Show("Please enter the vehicle price", "Vehicle Price");
                priceTextBox.Focus();
                return;
            }
            try
            {
                vehiclePrice = decimal.Parse(priceTextBox.Text);
                totalVehicles += 1;
            }
            catch
            {
                MessageBox.Show("Please enter the numbers only", "Vehicle Price");
                priceTextBox.SelectAll();
                priceTextBox.Focus();
                return;
            }

            // input and validate trade-in price
            if (lessTextBox.Text == "")
            {
                lessTextBox.Text = "0";
            }
            try
            {
                tradeInPrice = decimal.Parse(lessTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please put the trade-in price or zero", "Less Trade-in");
                lessTextBox.SelectAll();
                lessTextBox.Focus();
                return;
            }

            // calculate warranty cost
            warVehCost = calWarrantyCost(vehiclePrice);

            // calculate extras cost
            extrasCost = extrasVehicleCost();

            // calculate insuranse cost
            insuranceCost = calcInsuranseCost(vehiclePrice, extrasCost);

            // calculate subamount, gstAmount, finalAmount, warranty cost, extras cost, total
            //vehicles sold, total amount

            const decimal GST_RATE = .1m;       // GST = 10%
            
            subAmount = vehiclePrice - tradeInPrice + warVehCost + extrasCost + insuranceCost;
            gstAmount = subAmount * GST_RATE;
            finalAmount = subAmount + gstAmount;

            // output subamount, gstAmount, finalAmount
            subAmLabel.Text = subAmount.ToString("C");
            gstAmLabel.Text = gstAmount.ToString("C");
            finAmLabel.Text = finalAmount.ToString("C");

            //output customer name and phone, vehicle price, trade-in amount, warranty, 
            //optional extras, insurance, subtotal, GST, final amount.
            
            int[] priceString = new int[20];
            int[] tradeString = new int[20];
            //priceString[4] = "Vehicle Price:          ";
            //detailsListBox.Items.Add("Customer's Name:    " + comboBox2.Text);
            //detailsListBox.Items.Add("Phone Number:       " + comboBox1.Text);
            //detailsListBox.Items.Add("");
            //detailsListBox.Items[0] =  "Customer's Name:    " + nameString;
            //detailsListBox.Items.Add("Vehicle Price:          " + priceTextBox.Text);
            //detailsListBox.Items.Add("Trade-In:     " + lessTextBox.Text);
            //detailsListBox.Items.Add("");
            //detailsListBox.Items.Add("Warranty:                " + warVehCost);
            //detailsListBox.Items.Add("");
            //detailsListBox.Items.Add("Optional Extras:       " + extrasCost);
            //detailsListBox.Items.Add("");
            //detailsListBox.Items.Add("");
            //detailsListBox.Items.Add("Insurance:       " + insuranceCost);
            //detailsListBox.Items.Add("");
            //detailsListBox.Items.Add("Subtotal:       " + subAmount);
            //detailsListBox.Items.Add("GST (+10%):       " + gstAmount);
            //detailsListBox.Items.Add("Total:       " + finalAmount);

            // update daily totals
            totalVehiclesSold += totalVehicles;
            totalAmount += finalAmount;
 
            summaryButton.Enabled = true;

            summaryToolStripMenuItem.Enabled = true;
        }
             
        // calculate warranty cost
        private decimal calWarrantyCost(decimal vehiclePrice)
        {
            const decimal WAR_RATE_1 = 0.1m;      // Commission Rate 1 = 10 %
            const decimal WAR_RATE_2 = 0.2m;      // Commission Rate 2 = 20 %
            decimal warrantyCost = 0;             // local var to hold warranty cost

            if (noChargeRadioButton.Checked)
            {
                warrantyCost = 0;
            }
            else if (threeYearsRadioButton.Checked)
            {
                warrantyCost = vehiclePrice * WAR_RATE_1;
            }
            else if (fiveYearsRadioButton.Checked)
            {
                 warrantyCost = vehiclePrice * WAR_RATE_2;
            }
            return warrantyCost;
        }

        // calculate extras cost
        private decimal extrasVehicleCost()
        {
            //Find price for optional extras
            decimal extrasCost = 0;
            const decimal WINDOW_TINT = 150.00m;
            const decimal PROTECTION = 180.00m;
            const decimal NAVI = 320.00m;
            const decimal SOUND = 350.00m;

            if (tintingCheckBox.Checked)
            {
                extrasCost += WINDOW_TINT;
            }
            if (protectionCheckBox.Checked)
            {
                extrasCost += PROTECTION;
            }
            if (naviCheckBox.Checked)
            {
                extrasCost += NAVI;
            }
            if (soundCheckBox.Checked)
            {
                extrasCost += SOUND;
            }
            return extrasCost;
        }

        // enable age buttons
        private void policyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (policyCheckBox.Checked)
            {
                lessTwoFiveRadioButton.Enabled = true;
                moreEqTwoFiveRadioButton.Enabled = true;
            }
            else
            {
                lessTwoFiveRadioButton.Enabled = false;
                moreEqTwoFiveRadioButton.Enabled = false;
            }
        }

        //  calculate insuranse cost
        private decimal calcInsuranseCost(decimal vehiclePrice, decimal extrasCost)
        {
            decimal insuranseCost = 0;
            const decimal LESS_TWO_FIVE = .2m;
            const decimal MORE_TWO_FIVE = .1m;
            if (policyCheckBox.Checked == true)
            {
                if (lessTwoFiveRadioButton.Checked)
                {
                    insuranseCost = (vehiclePrice + extrasCost) * LESS_TWO_FIVE;
                }
                else
                {
                    insuranseCost = (vehiclePrice + extrasCost) * MORE_TWO_FIVE;
                }
            }
            return insuranseCost;
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // display the summary information in the box
            MessageBox.Show("Vehicles sold: " + totalVehiclesSold.ToString()
                + "\n\n" + "Total Daily Amount: " + totalAmount.ToString("C"), "Daily Summary"); 
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // clear all text boxes and output labels, set focus to phone text box
            comboBox1.Text = "";
            comboBox2.Text = "";
            priceTextBox.Text = "";
            lessTextBox.Text = "";
            noChargeRadioButton.Checked = true;
            tintingCheckBox.Checked = false;
            protectionCheckBox.Checked = false;
            naviCheckBox.Checked = false;
            soundCheckBox.Checked = false;
            policyCheckBox.Checked = false;
            lessTwoFiveRadioButton.Enabled = false;
            moreEqTwoFiveRadioButton.Enabled = false;
            subAmLabel.Text = "";
            gstAmLabel.Text = "";
            finAmLabel.Text = "";
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            detailsListBox.Items.Clear();
            comboBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public object vehiclePrice { get; set; }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {    //display summary data on a separate Form (summaryForm)
            summaryForm mySummaryForm = new summaryForm();
            mySummaryForm.VehiclesSold = totalVehiclesSold;
            mySummaryForm.AmountSold = totalAmount;
            mySummaryForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 myAboutBox = new AboutBox1();
            myAboutBox.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}