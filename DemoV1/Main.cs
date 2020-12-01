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

namespace App
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
      
        public Main()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
           
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login_from = new Login();
            this.Close();
            login_from.ShowDialog();
            
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
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (XtraMessageBox.Show(this, "Are you sure?", "Do you still want close ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        
                        break;
                }
            }
        }
    }
}