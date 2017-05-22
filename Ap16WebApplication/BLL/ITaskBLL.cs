using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public interface ITaskBLL
    {
        Task<List<DTO.TaskDetailsDTO>> GetAllTaskDetails();

    }
}