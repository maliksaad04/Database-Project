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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OD formOD = new OD(); // Create an instance of Form OD
            formOD.Show(); // Show Form OD
            this.Hide();  // Hide the current form
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OSM formOSM = new OSM(); // Create an instance of Form OSM
            formOSM.Show(); // Show Form OSM
            this.Hide();  // Hide the current form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OCM formOCM = new OCM(); // Create an instance of Form OCM
            formOCM.Show(); // Show Form OCM
            this.Hide();  // Hide the current form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OMM formOMM = new OMM(); // Create an instance of Form OMM
            formOMM.Show(); // Show Form OMM
            this.Hide();  // Hide the current form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OOM formOOM = new OOM(); // Create an instance of Form OOM
            formOOM.Show(); // Show Form OOM
            this.Hide();  // Hide the current form
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OFM formOFM = new OFM(); // Create an instance of Form OFM
            formOFM.Show(); // Show Form OFM
            this.Hide();  // Hide the current form
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OSP formOSP = new OSP(); // Create an instance of Form OSP
            formOSP.Show(); // Show Form OSP
            this.Hide();  // Hide the current form
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Create an instance of Form2
            form1.Show(); // Show Form2
            this.Hide(); // Hide the current form (optional)
        }
    }
}
