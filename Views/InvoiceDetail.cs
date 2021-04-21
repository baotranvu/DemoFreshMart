
using System.Windows.Forms;
using Interfaces;
using DevExpress.XtraEditors;


namespace Views
{
    public partial class InvoiceDetail : Form, IInvoiceDetail
    {
        public BindingSource BindingSource { get => invoice_detailBindingSource;  set => invoice_detailBindingSource = value; }
        
        public InvoiceDetail()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(InvoicePrintExit);
            Load += delegate { item_lb.Text = BindingSource.Count.ToString() + "item(s)"; };
            
        }

      
    

        public void ShowModal()
        {
            ShowDialog();
            
        }
        
        

        public void InvoicePrintExit(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if(e.KeyCode == Keys.P && e.Control)
            {
                layoutControl1.ShowRibbonPrintPreview();
                
            }
            
        }

        
    }
}