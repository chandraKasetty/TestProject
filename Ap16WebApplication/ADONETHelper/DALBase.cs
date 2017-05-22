using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace ADONETHelper
{
    public interface IDalBase
    {
        DbConnection GetDbConnection();
    }


    public abstract class DalBase : DalFactory, IDalBase
    {
        public DbConnection GetDbConnection()
        {
            return GetDbProviderConnection();
        }

        #region Commands

        protected DbCommand GetDbCommand(string sqlQuery)
        {
            var connection = GetDbProviderConnection();
            var command = GetDbCommand(sqlQuery, connection);
            return command;
        }

        protected DbCommand GetDbCommand(string sqlQuery, DbConnection connection)
        {
            var command = GetDbProviderCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            return command;
        }

        protected DbCommand GetDbCommandForStoredProc(string storedProcName, DbConnection connection, List<DalParameter> parameters)
        {
            var command = GetDbProviderCommand();
            command.CommandText = storedProcName;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            var providerParameter = GetDbProviderParameter();

            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter.CreateDbParamater(providerParameter));
            }

            return command;

        }

        #endregion

        #region GETS
        protected List<T> GetDataObjectOfT<T>(DbConnection connection, string sqlQuery)
        {
            
            return connection.Query<T>(sqlQuery).ToList();

        }

        protected async Task<IEnumerable<T>> GetDataObjectOfTAsync<T>(DbConnection connection, string sqlQuery)
        {

            return await connection.QueryAsync<T>(sqlQuery);

        }

        protected List<T> GetDataObjectOfTByStroredProc<T>(DbConnection connection, string stroredProcName, DynamicParameters dynamicParameters)
        {
            return connection.Query<T>("stroredProcName", dynamicParameters, commandType: CommandType.StoredProcedure).ToList();

        }

       
        protected DataSet GetDataSet(DbCommand command)
        {
            var da = GetDbProviderDataAdapter();
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
 

        protected DataTable GetDataTable(DbCommand command)
        {
            var da = GetDbProviderDataAdapter();
            da.SelectCommand = command;
            var ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        #endregion

        #region EXECUTE NON-QUERY

        protected int ExecuteNonQuery(DbCommand command)
        {
            return command.ExecuteNonQuery();
        }


        #endregion

        #region EXECUTE SCALAR
        protected T ExecuteScalar<T>(DbCommand command)
        {
            var result = command.ExecuteScalar();

            if (System.DBNull.Value.Equals(result))
            {
                return default(T);
            }
            else
            {
                return (T)result;
            }

        }

        protected async Task<T> ExecuteScalarAsync<T>(DbCommand command)
        {
            var result = await command.ExecuteScalarAsync();

            if (System.DBNull.Value.Equals(result))
            {
                return default(T);
            }
            else
            {
                return (T)result;
            }

        }

        #endregion

        #region ExecuteReader

        protected DbDataReader ExecuteReader(DbCommand command)
        {
            return command.ExecuteReader();
        }
        #endregion
    }

}
