using System.Configuration;
using ADONETHelper;
using DAL.Properties;

namespace DAL
{
    public class AP16Database : DalBase, IAP16Database
    {
        protected override DbProvider CurrentDbProvider => DbProvider.SqlServer;
        
        protected override string ConnectionString => GetConnectionString();

        private string GetConnectionString()
        {
            // PLEASE USE CONNECTION STRING OF DATABASE YOU USE
            return Settings.Default.AP16DBConnectionString;
        }
    }
}