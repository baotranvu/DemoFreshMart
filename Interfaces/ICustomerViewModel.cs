using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface ICustomerViewModel
    {
        BindingSource CustomerBindingSource { get; set; }
        string Title { get; }
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void New();
        void Delete();
        void Save();
        void Load();
       
      
    }
}
