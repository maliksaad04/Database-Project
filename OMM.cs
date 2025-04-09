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
    public partial class OMM: Form
    {
        public OMM()
        {
            InitializeComponent();
        }

        private void OMM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OMMadd ommAddForm = new OMMadd(); // Create an instance of OMMadd form
            ommAddForm.Show(); // Show the OMMadd form
            this.Hide(); // (Optional) Hide the current form if needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OMMview viewManagersForm = new OMMview();
            viewManagersForm.Show(); // Opens the OMMview form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OMMupdate updateForm = new OMMupdate();
            updateForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  // Opens Form2
            this.Hide();    // Hides the current form (optional)
        }
    }
}
