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
    public partial class OMMadd: Form
    {
        public OMMadd()
        {
            InitializeComponent();
        }

        private void OMMadd_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OMM managerForm = new OMM();
            managerForm.Show();
        }
    }
}
