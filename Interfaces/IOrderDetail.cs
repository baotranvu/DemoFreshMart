using System.Windows.Forms;

namespace Interfaces
{
    public interface IOrderDetail
    {
        BindingSource BindingSource { get; set; }
        void ShowModal();
        
    }
}
