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
    public partial class OSMattendance: Form
    {
        public OSMattendance()
        {
            InitializeComponent();
        }

        private void OSMattendance_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OSM osmForm = new OSM(); // Create an instance of OSM Form
            osmForm.Show(); // Show the OSM Form
            this.Hide(); // Hide the current form (optional)
        }
    }
}
