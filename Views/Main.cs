using System;


namespace Views
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public Main()
        {
            InitializeComponent();
            
            this.accordionCustomer.Click += delegate { new Customers().ShowDialog(); };
            this.accordionEmployee.Click += delegate {  new Employees().ShowDialog(); };
            this.accordionProvider.Click += delegate {  new Provider().ShowDialog();  };
            this.accordionAuthentication.Click += delegate {  new Authentication().ShowDialog();  };
            this.accordionUser.Click += delegate {  new User().ShowDialog();  };
            this.accordionRole.Click += delegate {  new Role().ShowDialog();  };
            this.accordionNewInvoice.Click += delegate {  new New_Invoice().ShowDialog();  };
            this.accordionInvoices.Click += delegate {  new Invoice().ShowDialog();  };
            this.accordionNewOder.Click += delegate {  new New_Order().ShowDialog();  };
            this.accordionProductInfo.Click += delegate {  new Product().ShowDialog();  };

            this.accordionOder.Click += delegate { new Oder().ShowDialog(); };
            this.accordionFunction.Click += delegate { new Function().ShowDialog(); };
            this.FormClosing += delegate { this.Hide(); new Login().ShowDialog(); this.Close(); };
        }


    }
}