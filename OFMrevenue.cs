using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attempt_S.Resources
{
    public partial class OFMrevenue: Form
    {
        private OFM ofmForm; // Reference to OFM

        // Modify constructor to accept OFM instance
        public OFMrevenue(OFM formInstance)
        {
            InitializeComponent();
            ofmForm = formInstance; // Store OFM reference
        }

        private void OFMrevenue_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            // Fetch textBox9 value from OFM and display it in textBox2 (or any other textbox)
            textBox2.Text = ofmForm.TextBoxValue;
        }
        public OFMrevenue()
        {
            InitializeComponent();
        }

        private void OFM(object sender, EventArgs e)
        {

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }




        private void button2_Click(object sender, EventArgs e)
        {
            decimal value1 = decimal.Parse(textBox1.Text);
            decimal value2 = decimal.Parse(textBox6.Text);
            decimal value3 = decimal.Parse(textBox3.Text);

            // Calculate total sum
            decimal total = value1 + value2 + value3;

            // Display the result in txtTotal
            textBox4.Text = total.ToString("N2");  // Formats as currency
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OFM ofmForm = new OFM();
            ofmForm.Show();

            // Close the current form
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the input fields are empty
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter values in both text boxes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing values safely
            if (decimal.TryParse(textBox2.Text, out decimal value2) && decimal.TryParse(textBox4.Text, out decimal value4))
            {
                decimal result = value4 - value2; // Perform subtraction
                textBox5.Text = result.ToString("N2"); // Format as a number
            }
            else
            {
                MessageBox.Show("Invalid number format. Please enter numeric values only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Try parsing textBox5 value safely
            if (decimal.TryParse(textBox5.Text, out decimal value5))
            {
                if (value5 > 0)
                {
                    label6.Visible = true;  // Show panel1
                    label7.Visible = false; // Hide panel2
                }
                else
                {
                    label6.Visible = false; // Hide panel1
                    label7.Visible = true;  // Show panel2
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
