using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using BLL;

namespace WebApi.Controllers
{
    public class TaskController : ApiController
    {

        private readonly ITaskBLL _taskBll;

        public TaskController(ITaskBLL taskBll)
        {
            if (taskBll == null)
            {
                throw new ArgumentNullException("TaskBll cannot be null");
            }
            _taskBll = taskBll;
        }

        /// <summary>
        /// Calling TaskBLL
        /// </summary>
        /// <returns></returns>
        public async Task<List<DTO.TaskDetailsDTO>> GetTaskDetails()
        {
            return await _taskBll.GetAllTaskDetails();
        }
    }
}