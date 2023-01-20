using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hasitha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prg();
        }
        public void prg()
        {

            progressBar1.Increment(5);
            lblprgbarCount.Text = " " + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                // MessageBox.Show("Server has been connected");
                // this.Close();
                //timer1.Stop();
                btnColse.Enabled = true;
            }
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFrame f2 = new MainFrame();
            f2.Show();
            this.Hide();
        }
    }
}
