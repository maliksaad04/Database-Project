using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt_S.Resources
{
    public partial class MPM: Form
    {
        public MPM()
        {
            InitializeComponent();
        }

        private void MPM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the MPMadd_bill form
            MPMadd_bill addBillForm = new MPMadd_bill();

            // Show the MPMadd_bill form
            addBillForm.Show();

            // Hide the current form (Optional)
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if textBox3 has a value
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Convert textBox3 and textBox1 values to numbers
                decimal value1 = decimal.Parse(textBox3.Text);
                decimal value2 = decimal.Parse(textBox1.Text);

                // Multiply the values
                decimal totalAmount = value1 * value2;

                // Show the result in textBox6
                textBox6.Text = "Rs " + totalAmount.ToString("N2");

             

            }
            else
            {
                MessageBox.Show("Please enter values in both Quantity and Price.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Loop through all controls in the form
            foreach (Control control in this.Controls)
            {
                // Check if the control is a TextBox
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Clear the text
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
