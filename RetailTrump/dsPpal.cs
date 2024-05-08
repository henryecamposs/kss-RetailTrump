using System.Data.OleDb;

namespace RetailTrump
{


    partial class dsPpal
    {
        partial class invenDataTable
        {

        }
    }
}

namespace RetailTrump.dsPpalTableAdapters
{
    partial class inven_usaTableAdapter
    {
    }

    public partial class invenTableAdapter
    {
    
        public void FiltrarFilas(string sql)
        {
            this.CommandCollection[0].CommandText = sql;
        }
       
    }
}
