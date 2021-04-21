using System.Windows.Forms;
namespace Interfaces
{
    public interface IInvoiceDetailView
    {
        
        BindingSource BindingSource { get; set; }
        void ShowModal();
        void PrintOrExit(object sender, KeyPressEventArgs e);
    }
}
