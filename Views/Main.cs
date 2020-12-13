using System;


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
           
            Customers customer = new Customers();
            customer.ShowDialog();
           
        }

        private void accordionEmployee_Click(object sender, EventArgs e)
        {
            
            Employees employee = new Employees();
            employee.ShowDialog();
            
        }

        private void accordionProvider_Click(object sender, EventArgs e)
        {
            
            Provider provider = new Provider();
            provider.ShowDialog();
            
                
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Login login = new Login();
            login.ShowDialog();
            
        }
        

        private void accordionNewInvoice_Click(object sender, EventArgs e)
        {
            
            New_Invoice newinvoice = new New_Invoice();
            newinvoice.ShowDialog();
            
        }

        private void accordionProductsInfo_Click(object sender, EventArgs e)
        {
            New_Order neworder = new New_Order();
            neworder.ShowDialog();
           
        }

        private void accordionNewOrder_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
            
            
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionUserTab_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void accordionRole_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.ShowDialog();
        }

        private void accordionFunction_Click(object sender, EventArgs e)
        {
            Function function = new Function();
            function.ShowDialog();
        }

        private void accordionAuthentication_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.ShowDialog();

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        
    }
}