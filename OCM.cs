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
    public partial class OCM: Form
    {
        public OCM()
        {
            InitializeComponent();
        }

        private void OCM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OCMadd ocmAddForm = new OCMadd(); // Create an instance of OCMadd form
            ocmAddForm.Show(); // Show the OCMadd form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create an instance of Form2
            form2.Show(); // Show Form2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OCMview ocmViewForm = new OCMview(); // Create an instance of OCMview form
            ocmViewForm.Show(); // Show OCMview form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OCMupdate ocmUpdateForm = new OCMupdate(); // Create an instance of OCMupdate form
            ocmUpdateForm.Show(); // Show OCMupdate form
        }
    }
}
