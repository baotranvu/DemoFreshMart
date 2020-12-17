using System.Windows.Forms;
namespace Interfaces
{
    public interface IDetailView
    {
        void ShowModal();
        BindingSource BindingSource { get; set; }
        
    }
}
