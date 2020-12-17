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
using Interfaces;
using System.Data.Entity;

namespace Views
{
    public partial class Invoice_detail : Form, IDetailView
    {
        public BindingSource BindingSource { get => invoice_detailBindingSource;  set => invoice_detailBindingSource = value; }
        
        public Invoice_detail()
        {

            InitializeComponent();
            gridControl1.KeyPress += new KeyPressEventHandler(PrintOrExit);
            


        }

        

        public void ShowModal()
        {
           
            ShowDialog();
            

        }

        
        private void PrintOrExit(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyChar == (char)Keys.P)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.ShowDialog();
            }
        }

        
    }
}