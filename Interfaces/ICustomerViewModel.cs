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
        void AddAsync(string name, string gender, System.DateTime birth, string address, string phone, string mail, string temp);
        void Clear(DevExpress.XtraLayout.LayoutControlGroup layoutControl);
        
       
      
    }
}
