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
    public partial class OSMupdate: Form
    {
        public OSMupdate()
        {
            InitializeComponent();
        }

        private void OSMupdate_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of OSMview form
            OSM viewForm = new OSM();

            // Show the OSMview form
            viewForm.Show();

            // Optional: Hide the current form
            this.Hide();
        }
    }
}
