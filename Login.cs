using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hasitha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=NAVEEN_DELL_14;Initial Catalog=DB_SupMarket;Integrated Security=True");

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
            txtUserName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFrame f2 = new MainFrame();
            f2.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username= txtUserName.Text;
            user_password= txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM login WHERE username= '"+txtUserName.Text+"' AND password ='"+txtPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    user_password = txtPassword.Text;

                    MainFrame f1= new MainFrame();
                    f1.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Incorrect username or password!","Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();

                    txtUserName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
