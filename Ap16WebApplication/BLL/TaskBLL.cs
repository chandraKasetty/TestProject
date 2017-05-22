using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaskBLL : ITaskBLL
    {
        private readonly ITaskDAL _taskDal;
        private readonly IAttachmentsDAL _attachmentsDal;
        private readonly IAssigneesDAL _assigneesDal;
        public TaskBLL(ITaskDAL taskDal, IAttachmentsDAL attachmentsDal, IAssigneesDAL assigneesDal)
        {
            _taskDal = taskDal?? throw new ArgumentException("TaskDal cannot be null.");
            _attachmentsDal = attachmentsDal ?? throw new ArgumentException("TaskDal cannot be null.");
            _assigneesDal = assigneesDal ?? throw new ArgumentException("TaskDal cannot be null.");
        }


        public async Task<List<DTO.TaskDetailsDTO>> GetAllTaskDetails()
        {
            try
            {
                using (var con = _taskDal.GetDbConnection())
                {
                    await ((DbConnection)con).OpenAsync(CancellationToken.None).ConfigureAwait(false);

                    
                    var tasks=  await _taskDal.GetAllTasksAsync(con);
                    var attachments = await _attachmentsDal.GetAttachments(con);
                    var assignee = await _assigneesDal.GetAssignees(con);


                    return await System.Threading.Tasks.Task.Run(() => (from t in tasks
                                                                        join p in assignee
                                                                        on t.AssigneeId equals p.Id
                                                                        orderby t.DueDate
                                                                        select new TaskDetailsDTO()
                                                                        {
                                                                            Id=t.Id,
                                                                            Name = t.Name,
                                                                            Description = t.Description,
                                                                            Status = getStatus(t.StatusId),
                                                                            DueDate = t.DueDate,
                                                                            PersonAssignedTo = p.Name,
                                                                            PersonAssignedToId = p.Id,
                                                                            Attachments = attachments.Where(y => y.TaskId == t.Id).ToList()
                                                                        }).ToList());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        private DTO.StatusDTO getStatus(int statusId)
        {
            // depending on the id passed returns status
            // for now return some value
            return StatusDTO.Completed;
        }
    }
}
