using System;
using ViewModels;
using DevExpress.XtraEditors;


namespace Views
{
    public partial class New_Customer : DevExpress.XtraEditors.XtraForm
    {

        private CustomerViewModel vm = new CustomerViewModel();
        public New_Customer()
        {
            InitializeComponent();
            
            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Password.Text.Equals(Confirm.Text))
            {
                string name = FirstName.Text + LastName.Text;
                string gender = Gender.SelectedItem.ToString();
                DateTime birth = DateTime.Parse(Date.Text);
                string address = Address.Text;
                string phone = Phone.Text;
                string mail = Mail.Text;
                vm.AddAsync(name, gender, birth, address, phone, mail, Password.Text);
            }
            else
            {
                XtraMessageBox.Show("password doesn't match!");
                Confirm.Focus();
            }
            
                
           
                
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            vm.Clear(Root);
        }
    }
}