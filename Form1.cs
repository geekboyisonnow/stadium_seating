using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void classBCalculatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void classATextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void classBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classACalculatedLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void calculatedRevenueButton_Click(object sender, EventArgs e)
        {
            // Number of Class A Tickets.
            decimal classATickets;
            // Price of Class A Ticket.
            decimal classATicketPrice = 15.00m;

            // Number of Class B Tickets.
            decimal classBTickets;
            // Price of Class B Tickets
            decimal classBTicketPrice = 12.00m;

            // Number of Class C Tickets.
            decimal classCTickets;
            // Price of Class C Ticket.
            decimal classCTicketPrice = 9.00m;

            // Total Ticket Revenue.
            decimal totalRevenue;

            // Convert Text String to Decimal.
            classATickets = decimal.Parse(classATextBox.Text);
            classBTickets = decimal.Parse(classBTextBox.Text);
            classCTickets = decimal.Parse(classCTextBox.Text);

            // Declare Class Totals.
            decimal classATotal;
            decimal classBTotal;
            decimal classCTotal;

            //Perform Calculations for Class Totals.
            classATotal = classATickets * classATicketPrice;
            classACalculatedLabel.Text = classATotal.ToString("c");

            classBTotal = classBTickets * classBTicketPrice;
            classBCalculatedLabel.Text = classBTotal.ToString("c");

            classCTotal = classCTickets * classCTicketPrice;
            classCCalculatedLabel.Text = classCTotal.ToString("c");

            // Perform Total Revenue Calculations.
            totalRevenue = classATotal + classBTotal + classCTotal;
            totalCalculatedLabel.Text = totalRevenue.ToString("c");
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            classACalculatedLabel.Text = "";
            classBCalculatedLabel.Text = "";
            classCCalculatedLabel.Text = "";
            totalCalculatedLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
