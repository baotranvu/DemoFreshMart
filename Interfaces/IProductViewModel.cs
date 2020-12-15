using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IProductViewModel
    {
        BindingSource ProductBindingSource { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void Delete();
        void Update();
        void Load();
        void Add(string name, string type, string unit, decimal unitprice,System.DateTime mfg, System.DateTime exp );
    }
}
