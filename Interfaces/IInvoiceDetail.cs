using System.Windows.Forms;
namespace Interfaces
{
    public interface IInvoiceDetail
    {
        BindingSource BindingSource { get; set; }
        void ShowModal();
        
    }
}
