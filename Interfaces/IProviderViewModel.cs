using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IProviderViewModel
    {
        BindingSource ProviderBindingSource { get; set; }
        string Title { get; }
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void Delete();
        void Update();
        void Load();

    }
}
