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
    public partial class MOM: Form
    {
        public MOM()
        {
            InitializeComponent();
        }

        private void MOM_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of Form3
            Form3 form3 = new Form3();

            // Show Form3
            form3.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
