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
    public partial class MSM: Form
    {
        public MSM()
        {
            InitializeComponent();
        }

        private void MSM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSMadd msmAddForm = new MSMadd();

            // Show the MSMadd form
            msmAddForm.Show();

            // Optional: Hide the current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MSMview msmViewForm = new MSMview();

            // Show the MSMview form
            msmViewForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MSMupdate msmupdateForm = new MSMupdate();

            // Show the MSMview form
            msmupdateForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MSMattendace msmViewForm = new MSMattendace();

            // Show the MSMview form
            msmViewForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Form3 msmForm = new Form3 ();

            // Show the MSM form
            msmForm.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
