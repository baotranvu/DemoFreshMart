using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace ViewModels
{
    public class Functions
    {
        public void Clear(LayoutControlGroup layoutControl)
        {
            DevExpress.XtraLayout.Utils.LayoutGroupItemCollection items = layoutControl.Items;
            foreach (BaseLayoutItem item in items)
            {
                LayoutControlItem edt = item as LayoutControlItem;
                TextEdit textEdit = edt.Control as TextEdit;
                if (textEdit != null)
                {
                    textEdit.Text = string.Empty;
                }
                else
                {
                    continue;
                }

            }



        }
    }
}

