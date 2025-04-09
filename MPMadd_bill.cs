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
    public partial class MPMadd_bill: Form
    {
        public MPMadd_bill()
        {
            InitializeComponent();
        }

        private void MPMadd_bill_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the MPM form
            MPM mpmForm = new MPM();

            // Show the MPM form
            mpmForm.Show();

            // Hide the current form (Optional)
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Create an instance of Form3
            form3.Show(); // Show Form3
            this.Hide();  // Hide the current form (optional)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPMadd mpmAddForm = new MPMadd(); // Create an instance of MPMadd form
            mpmAddForm.Show(); // Show MPMadd form
            this.Hide(); // Hide the current form (optional)
        }
    }
}
