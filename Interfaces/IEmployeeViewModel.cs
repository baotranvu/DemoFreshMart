using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IEmployeeViewModel
    {
        BindingSource EmployeeBindingSource { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void Delete();
        void Update();
        void Load();
        void AddAsync(string name, string gender, System.DateTime birth, string address, string phone, string pass);
       
    }
}
