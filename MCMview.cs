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
    public partial class MCMview: Form
    {
        public MCMview()
        {
            InitializeComponent();
        }

        private void MCMview_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Create an instance of Form3
            form3.Show(); // Show Form3
            this.Hide(); // Hide the
        }
    }
}
