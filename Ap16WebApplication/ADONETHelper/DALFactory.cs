using System;
using System.Data.Common;

namespace ADONETHelper
{
    public abstract class DalFactory
    {
        protected enum DbProvider
        {
            SqlServer,
            MySql,
            OleDb
        }

        protected abstract DbProvider CurrentDbProvider { get; }
        protected abstract string ConnectionString { get; }

        protected DbConnection GetDbProviderConnection()
        {
            switch (CurrentDbProvider)
            {
                case (DbProvider.MySql):
                    throw new NotImplementedException("DbProvider MySQL is not implemented.");
                case DbProvider.OleDb:
                    throw new NotImplementedException("DbProvider OLEDB is not implemented.");
                case DbProvider.SqlServer:
                    return new System.Data.SqlClient.SqlConnection(ConnectionString);
                default:
                    throw new NotSupportedException("Unknown DbProvider is not supplied.");
            }
        }

        protected DbDataAdapter GetDbProviderDataAdapter()
        {
            switch (CurrentDbProvider)
            {
                case (DbProvider.MySql):
                    throw new NotImplementedException("DbProvider MySQL is not implemented.");
                case DbProvider.OleDb:
                    throw new NotImplementedException("DbProvider OLEDB is not implemented.");
                case DbProvider.SqlServer:
                    return new System.Data.SqlClient.SqlDataAdapter();
                default:
                    throw new NotSupportedException("Unknown DbProvider is not supplied.");
            }
        }
        
        protected DbParameter GetDbProviderParameter()
        {
            switch (CurrentDbProvider)
            {
                case (DbProvider.MySql):
                    throw new NotImplementedException("DbProvider MySQL is not implemented.");
                case DbProvider.OleDb:
                    throw new NotImplementedException("DbProvider OLEDB is not implemented.");
                case DbProvider.SqlServer:
                    return new System.Data.SqlClient.SqlParameter();
                default:
                    throw new NotSupportedException("Unknown DbProvider is not supplied.");
            }
        }

        protected DbCommand GetDbProviderCommand()
        {
            switch (CurrentDbProvider)
            {
                case (DbProvider.MySql):
                    throw new NotImplementedException("DbProvider MySQL is not implemented.");
                case DbProvider.OleDb:
                    throw new NotImplementedException("DbProvider OLEDB is not implemented.");
                case DbProvider.SqlServer:
                    return new System.Data.SqlClient.SqlCommand();
                default:
                    throw new NotSupportedException("Unknown DbProvider is not supplied.");
            }
        }
    }
}
