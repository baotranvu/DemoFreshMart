using System.ComponentModel;
using System.Windows.Forms;

namespace ViewModels
{
    public interface ICustomerViewModel
    {
        BindingSource CustomerBindingSource { get; set; }
        string Title { get; }
        event PropertyChangedEventHandler PropertyChanged;
        void Initialize();
        void New();
        void Delete();
        void Save();
        void Load();
      
    }
}
