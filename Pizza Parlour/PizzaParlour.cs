using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class PizzaParlour : Form
    {
        //Global variables
        double basePrice = 7.00;
        double toppingPrice = 1.25;
        double toppingsDesired;
        double totalPrice;

        public PizzaParlour()
        {
            InitializeComponent();

           
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            toppingsDesired = Convert.ToDouble(toppingsNumber.Text);
            totalPrice = (toppingPrice * toppingsDesired) + basePrice;

            outputLabel.Text = $"The price of a pizza with {toppingsDesired} toppings is:";
            outputLabel.Text += $"\n {totalPrice.ToString("C")}";
        }
    }
}
