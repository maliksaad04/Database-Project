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
    public partial class MSMadd: Form
    {
        public MSMadd()
        {
            InitializeComponent();
        }

        private void MSMadd_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MSM msmForm = new MSM();

            // Show the MSM form
            msmForm.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
