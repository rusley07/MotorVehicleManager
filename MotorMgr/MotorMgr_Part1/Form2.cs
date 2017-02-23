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
    public partial class summaryForm : Form
    {
        public summaryForm()
        {
            InitializeComponent();
        }

        private decimal totalVehiclesSold = 0;
        private decimal totalAmount = 0;
       
        public decimal VehiclesSold
        {
            set
            {
                totalVehiclesSold = value;
            }
        }

        public decimal AmountSold
        {
            set
            {
                totalAmount = value;
            }
        }

       private void summaryForm_Activated(object sender, EventArgs e)
        {
            decimal avg = totalAmount / totalVehiclesSold;
            totalCarsSoldLabel.Text = totalVehiclesSold.ToString();
            dailySalesAmountLabel.Text = totalAmount.ToString();
            dailySalesLabel.Text = avg.ToString("N2");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
