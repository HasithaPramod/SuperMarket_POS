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
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel8_Click(object sender, EventArgs e)
        {
            loadform(new CustomerDetails());
            /*CustomerDetails f1= new CustomerDetails();
            f1.Show();*/

        }

        public void loadform(object Form) 
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f= Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag= f;
            f.Show();
        }

        private void purchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem f3 = new AddItem();
            f3.Show();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegistration f4= new UserRegistration();
            f4.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinimizertoolStripMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new StockDetails());
            /*StockDetails f1= new StockDetails();
            f1.Show();*/
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            loadform(new StockDetails());
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new PurchaseHistory());
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories f2 = new Categories();
            this.Hide();
            f2.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetails f3 = new CustomerDetails();
            this.Hide();
            f3.Show();
        }

        private void workSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkSheet f4 = new WorkSheet();
            this.Hide();
            f4.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            AddCustormer f5 = new AddCustormer();
            this.Hide();
            f5.Show();
        }
    }
}
