using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IEmployeeViewModel
    {
        BindingSource EmployeeBindingSource { get; set; }
        string Title { get; }
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void Delete();
        void Update();
        void Load();

    }
}
