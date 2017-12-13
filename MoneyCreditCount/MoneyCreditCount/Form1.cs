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
        int costPerCredit = 5;
        int totalValue = 0;

        

        public MoneyCreditCounter()
        {
            InitializeComponent();

            //textBox1.Text = totalValue.ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void MoneyCreditCounter_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (costPerCredit <= 0)
            {
                MessageBox.Show("Please enter the cost per credit");
            }
            else
            {
                totalValue = totalValue + 1;
                textBox1.Text = totalValue.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
