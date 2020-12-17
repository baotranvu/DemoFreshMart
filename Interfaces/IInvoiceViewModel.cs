using System.ComponentModel;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IInvoiceViewModel
    {
      BindingSource InvoiceBindingSource { get; set; }
      event PropertyChangedEventHandler PropertyChanged;
      void Dispose();
      void Load();
      void ShowDetail(IDetailView detail);


    }
}
