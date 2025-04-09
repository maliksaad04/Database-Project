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
    public partial class MCMupdate: Form
    {
        public MCMupdate()
        {
            InitializeComponent();
        }

        private void MCMupdate_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MCM mcmForm = new MCM();

            // Show the MSM form
           // mcmForm.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
