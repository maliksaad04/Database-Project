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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MSM msm = new MSM();

            // Show the MSMadd form
            msm.Show();

            // Optional: Hide the current form
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MCMview mcmViewForm = new MCMview(); // Create an instance of MCMview form
            mcmViewForm.Show(); // Show the MCMview form
            this.Hide(); // Hide the current form (optional)// Create an instance of the MCM form
            //MCM mcmForm = new MCM();

            // Show the MCM form
            //mcmForm.Show();

            // Hide the current form (optional)
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of MOM form
            MOM momForm = new MOM();

            // Show MOM form
            momForm.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MPMadd_bill addBillForm = new MPMadd_bill();
            addBillForm.Show();
            this.Close(); // Closes the current form
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Create an instance of Form1
            form1.Show(); // Show Form1
            this.Hide();  // Hide the current form (optional)
        }
    }
}
