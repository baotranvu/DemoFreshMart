using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface ICustomerViewModel
    {
        BindingSource CustomerBindingSource { get; set; }
        string Title { get; }
        event PropertyChangedEventHandler PropertyChanged;
        void Initializze();
        void Dispose();
        void Delete();
        void Update();
        void Load();
       
      
    }
}
