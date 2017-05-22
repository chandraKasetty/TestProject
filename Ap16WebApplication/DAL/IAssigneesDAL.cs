using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface IAssigneesDAL
    {
        Task<IEnumerable<AssigneesDTO>> GetAssignees(DbConnection conn);

    }
}