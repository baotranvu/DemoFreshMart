using Unity;
using System.Windows.Forms;
using Interfaces;
using DevExpress.XtraEditors;
using System.Drawing.Printing;

namespace Views
{
    public partial class OrderDetail : Form, IOrderDetailView
    {
        private IDetailView _vm = Config.Container.Resolve<IDetailView>();
        public OrderDetail()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(PrintOrExit);
        }

        public BindingSource BindingSource { get => order_DetailBindingSource; set => order_DetailBindingSource = value; }

        public void PrintOrExit(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Escape)
            {
                if(XtraMessageBox.Show("Exit?","Warning!",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    this.Dispose();
                }
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

        public void ShowModal()
        {
            ShowDialog();
        }
       


    }
}
