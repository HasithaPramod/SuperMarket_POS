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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void btnAddNewCustLink_Click(object sender, EventArgs e)
        {
            AddNewCustomer f1 = new AddNewCustomer();
            f1.Show();
        }
    }

}
