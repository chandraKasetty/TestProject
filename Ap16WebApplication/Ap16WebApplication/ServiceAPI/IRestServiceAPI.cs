using System.Collections.Generic;
using System.Threading.Tasks;
using DTO;

namespace Ap16WebApplication.ServiceAPI
{
    public interface IRestServiceApi
    {
        Task<List<TaskDetailsDTO>> GetTaskDetailsAsync();
    }

}