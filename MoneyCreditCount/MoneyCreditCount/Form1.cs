using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCreditCount
{
    public partial class MoneyCreditCounter : Form
    {
        int costPerCredit = 0;  //setting initial values
        int totalValue = 0;
        int dividedTotalValue;
        int onePvalue = 0;
        int twoPvalue = 0;
        int fivePvalue = 0;
        int tenPvalue = 0;
        int twentyPvalue = 0;
        int fiftyPvalue = 0;
        int onePoundValue = 0;
        int twoPoundValue = 0;
        double totalValueMoney = 0;


        
        

        public MoneyCreditCounter()
        {
            InitializeComponent();


            //textBox1.Text = totalValue.ToString();
        }

        public void updateBoxes()   //method to update numbers after clicking a coin. Makes code tidy later on
        {
            textBox1.Text = totalValue.ToString();  //Converts the totalValue varibale to a string and displays it in the Total Value box. This updates whenver a coin is clicked
            dividedTotalValue = totalValue / costPerCredit; // dividedTotalValue is how many credits you have. Worked out by dividing totalValue by the cost per credit
            textBox4.Text = dividedTotalValue.ToString();   // sets number of credits to new value
            textBox2.Text = totalValueMoney.ToString("N");  // Sets the total value in £s box. ("N") means 2 decimal places
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void MoneyCreditCounter_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            costPerCredit = int.Parse(textBox3.Text); //Converts the value from the textBox into an int and setting it as costPerCredit
        }

        private void pictureBox1_Click(object sender, EventArgs e)  // 1p
        {
            if (costPerCredit <= 0)
            {
                MessageBox.Show("Please enter a positive value for the Cost Of Credit");    // Makes it so nothing can happen until a Cost Per Credit is set
            }
            else
            {
                totalValue = totalValue + 1;    // Adds 1 because its a 1p coin
                onePvalue = onePvalue + 1;  // Adds 1 to how many 1ps have been used
                totalValueMoney = totalValueMoney + 0.01; // Adds 0.01 (money value) to show actual currency value

                label2.Text = onePvalue.ToString(); // Sets the number to how many 1ps have been used and logs in on the right of the window

                updateBoxes();  // Runs the method I made above
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (costPerCredit <= 0)
            {
                MessageBox.Show("Please enter a positive value for the Cost Of Credit");
            }
            else
            {
                totalValue = totalValue + 2;
                twoPvalue = twoPvalue + 2;
                
            }
        }
    }
}
//Coin code template
//
//if (costPerCredit <= 0)
//            {
//                MessageBox.Show("Please enter a positive value for the Cost Of Credit");    // Makes it so nothing can happen until a Cost Per Credit is set
//            }
//            else
//            {
//                totalValue = totalValue + 1;
//                onePvalue = onePvalue + 1;
//                totalValueMoney = totalValueMoney + 0.01;
//
//                label2.Text = onePvalue.ToString();
//
//                updateBoxes();
//            }