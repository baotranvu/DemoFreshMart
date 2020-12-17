using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using System.Windows.Forms;

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
        public bool EntityConnection(string user ,string pass)
        {
            bool check = false;
            string providerName = "System.Data.SqlClient";
            string serverName = "ADMIN\\SUPERMARKET";
            string databaseName = "SuperMarket";
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.UserID = user;
            sqlBuilder.Password = pass;
            string providerString = sqlBuilder.ToString();

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = providerName;
            entityBuilder.ProviderConnectionString = providerString;
            entityBuilder.Metadata = "res://*/FreshMart.csdl|res://*/FreshMart.ssdl|res://*/FreshMart.msl;provider=System.Data.SqlClient;";
            using (EntityConnection conn = new EntityConnection(entityBuilder.ToString()))
            {
                {
                    conn.Open();
                    XtraMessageBox.Show("Connected!");
                    check = true;
                }
            }

            return check;
        }
        
    }
}

