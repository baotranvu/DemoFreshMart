using Unity;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Interfaces;


namespace Views
{
    public partial class InvoiceDetail : Form, IInvoiceDetail
    {
       
        public BindingSource BindingSource { get => invoice_detailBindingSource;  set => invoice_detailBindingSource = value; }
        
        public InvoiceDetail()
        {

            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(PrintOrExit);


        }

        

        public void ShowModal()
        {
           
            this.ShowDialog();
            

        }

        
        private void PrintOrExit(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyChar == (char)Keys.P)
            {
                PrintDialog pDlg = new PrintDialog();
                PrintDocument pDoc = new PrintDocument();
                pDoc.DocumentName = "Print Document";
                pDlg.Document = pDoc;
                pDlg.AllowSelection = true;
                pDlg.AllowSomePages = true;
                if (pDlg.ShowDialog() == DialogResult.OK)
                {
                    pDoc.Print();
                }
                else
                {
                    XtraMessageBox.Show("Đã hủy in");
                }
            }
        }

        
    }
}