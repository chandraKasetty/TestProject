using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AssigneesDAL : AP16Database, IAssigneesDAL
    {
        public async Task<IEnumerable<AssigneesDTO>> GetAssignees(DbConnection conn)
        {

            var sql = @"SELECT Id
                            ,Name
                            FROM Assignees";

            return await GetDataObjectOfTAsync<AssigneesDTO>(conn, sql);

        }
    }
}