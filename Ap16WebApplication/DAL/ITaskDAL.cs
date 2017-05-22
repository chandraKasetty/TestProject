using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface ITaskDAL : IAP16Database
    {
        Task<IEnumerable<TaskDTO>> GetAllTasksAsync(DbConnection conn);

        Task<int> AddTask(DbConnection conn, TaskDetailsDTO taskDetails);

        Task<int> DeleteTask(DbConnection conn, int taskId);

        Task<int> EditTask(DbConnection conn, TaskDetailsDTO taskDetails);


    }
}