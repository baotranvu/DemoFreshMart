using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Interfaces;
using DevExpress.XtraEditors;


namespace Views
{
    public partial class OrderDetail : Form,IOrderDetail 
    {
        public OrderDetail()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(OrderPrintExit);
            Load += delegate { item_lb.Text = BindingSource.Count.ToString() + "item(s)"; };
        }

        public BindingSource BindingSource { get => orderDetailBindingSource; set => orderDetailBindingSource = value; }

        public void OrderPrintExit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
                layoutControl1.ShowRibbonPrintPreview();
            }
        }

        public void ShowModal()
        {
            ShowDialog();
        }
    }
}
