using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Views
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
      
        public Main()
        {
            InitializeComponent();
            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
           
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            
            Login login_from = new Login();
            login_from.ShowDialog();
            this.Hide();
            this.Close();
            
            
        }

       
        private void accordionCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void accordionEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ShowDialog();
        }

        private void accordionProvider_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.ShowDialog();
                
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        

        private void accordionNewInvoice_Click(object sender, EventArgs e)
        {
            New_Invoice newinvoice = new New_Invoice();
            newinvoice.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void accordionProductsInfo_Click(object sender, EventArgs e)
        {
            New_Order neworder = new New_Order();
            neworder.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void accordionNewOrder_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
            this.Hide();
            this.Close();
            
        }
    }
}