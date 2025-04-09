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
    public partial class OD: Form
    {
        public OD()
        {
            InitializeComponent();
        }

        private void OD_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create an instance of Form2
            form2.Show(); // Show Form2
            this.Hide(); // Hide the current form (optional)
        }
    }
}
