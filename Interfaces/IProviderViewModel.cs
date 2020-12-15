using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IProviderViewModel
    {
        BindingSource ProviderBindingSource { get; set; }
        
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void Delete();
        void Update();
        void Load();
        void Add(string name, string address, string phone, string mail,string bank,string account);

    }
}
