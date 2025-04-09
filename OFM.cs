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
    public partial class OFM: Form
    {
        public OFM()
        {
            InitializeComponent();
        }
        // Public property to get the text from textBox1
        public string TextBoxValue
        {
            get { return textBox9.Text; }
        }
        private void OFM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Hides the current form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            OFMrevenue revenueForm = new OFMrevenue(this); // Pass OFM instance
            revenueForm.Show(); // Open the revenue form
            this.Hide(); // Hide the current form (optional)
        }
        // This method allows another form to access the total expenses value
        public string GetTotalExpenses()
        {
            return textBox9.Text; // Make sure this is the correct name for the Total Expenses textbox
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Parse values from 8 textboxes
            decimal value1 = decimal.Parse(electricity.Text);
            decimal value2 = decimal.Parse(internet.Text);
            decimal value3 = decimal.Parse(laboursalary.Text);
            decimal value4 = decimal.Parse(managersalary.Text);
            decimal value5 = decimal.Parse(deliverycost.Text);
            decimal value6 = decimal.Parse(inventorytotal.Text);
            decimal value7 = decimal.Parse(rawmaterial.Text);
            decimal value8 = decimal.Parse(maintenancecost.Text);

            // Calculate total sum
            decimal total = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8;

            // Display the result in txtTotal
            textBox9.Text = total.ToString("N2");  // Formats as currency
        }
    }
}
