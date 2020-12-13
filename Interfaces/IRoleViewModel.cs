using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IRoleViewModel
    {
        BindingSource RoleBindingSource { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        void Add();
        void SaveAsync();
        void Delete();
        void Dispose();
        void Load();
    }
}
