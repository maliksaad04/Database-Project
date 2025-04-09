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
    public partial class OCMadd: Form
    {
        public OCMadd()
        {
            InitializeComponent();
        }

        private void OCMadd_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OCM ocmForm = new OCM(); // Create an instance of OCMadd form
            ocmForm.Show(); // Show the OCMadd form
        }
    }
}
