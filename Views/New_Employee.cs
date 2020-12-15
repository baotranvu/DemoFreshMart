using System;
using System.Collections.Generic;
using ViewModels;
using DevExpress.XtraEditors;

namespace Views
{
    public partial class New_Employee : DevExpress.XtraEditors.XtraForm
    {
        private EmployeeViewModel vm = new EmployeeViewModel();
        public New_Employee()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Password.Text.Equals(Confirm.Text))
            {
                string name = FirstName.Text + LastName.Text;
                string gender = Gender.SelectedItem.ToString();
                DateTime birth = DateTime.Parse(Date.Text);
                string address = Address.Text;
                string phone = Phone.Text;
                vm.Add(name, gender, birth, address, phone, Password.Text);
            }
            else
            {
                XtraMessageBox.Show("password doesn't match!");
                Confirm.Focus();
            }
        }
    }
       

        
}