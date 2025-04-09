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
    public partial class OCMupdate: Form
    {
        public OCMupdate()
        {
            InitializeComponent();
        }

        private void OCMupdate_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OCM ocmForm = new OCM(); // Create an instance of OCM form
            ocmForm.Show(); // Show OCM form
        }
    }
}
