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
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void lnkCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDetails f1 = new CustomerDetails();
            f1.Show();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //should add the saving data to db
            this.Close();
        }
    }
}
