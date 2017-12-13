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
        int costPerCredit = 0;
        int totalValue = 0;
        int dividedTotalValue;
        //string costPerCreditString;
        
        

        public MoneyCreditCounter()
        {
            InitializeComponent();


            //textBox1.Text = totalValue.ToString();
        }

        public void updateBoxes()
        {
            textBox1.Text = totalValue.ToString();
            dividedTotalValue = totalValue / costPerCredit;
            textBox4.Text = dividedTotalValue.ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (costPerCredit <= 0)
            {
                MessageBox.Show("Please enter a positive value for the Cost Of Credit");
            }
            else
            {
                totalValue = totalValue + 1;

                updateBoxes();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
