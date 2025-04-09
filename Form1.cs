using Attempt_S.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt_S
{
    public partial class Form1 : Form
    {
        private object chkShowPassword;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Admin Login Successful!");

                Form2 form2 = new Form2(); // Redirect to Form2
                form2.Show();
                this.Hide();
            }
            else if (username == "manager" && password == "manager")
            {
                MessageBox.Show("Manager Login Successful!");

                Form3 form3 = new Form3(); // Redirect to OFMrevenue form
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                textBox2.Focus(); // Move to the next textbox (or perform any action)

                            }
        }
    }
}
