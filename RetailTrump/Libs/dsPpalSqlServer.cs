namespace RetailTrump
{


    partial class dsPpalSqlServer
    {
    }
}

namespace RetailTrump.dsPpalSqlServerTableAdapters {
    
    
    public partial class INVENTableAdapter
    {
        public void FiltrarFilas(string sql)
        {
            this.CommandCollection[0].CommandText = sql;
        }
    }
}
