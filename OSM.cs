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
    public partial class OSM: Form
    {
        public OSM()
        {
            InitializeComponent();
        }

        private void OSM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OSMadd osmAddForm = new OSMadd(); // Create an instance of Form OSMadd
            osmAddForm.Show(); // Show the new form
            this.Hide(); // Hide the current form (optional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of OSMview form
            OSMview viewForm = new OSMview();

            // Show the OSMview form
            viewForm.Show();

            // Optional: Hide the current form
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create an instance of Form2
            form2.Show(); // Show Form2
            this.Hide(); // Hide the current form (optional)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OSMupdate updateForm = new OSMupdate(); // Create an instance of OSMupdate form
            updateForm.Show(); // Show the update form
            this.Hide(); // Hide the current form if needed
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OSMattendance attendanceForm = new OSMattendance(); // Create an instance of OSMattendance Form
            attendanceForm.Show(); // Show the OSMattendance Form
            this.Hide(); // Hide the current form (optional)
        }
    }
}
