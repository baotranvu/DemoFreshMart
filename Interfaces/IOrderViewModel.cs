using System.ComponentModel;
using System.Windows.Forms;


namespace Interfaces
{
    public interface IOrderViewModel
    {
        BindingSource OrderBindingSource { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        void Dispose();
        void Load();
        void ShowDetail(IOrderDetail detail);
    }
}
