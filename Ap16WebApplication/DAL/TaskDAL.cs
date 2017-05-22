using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaskDAL : AP16Database, ITaskDAL
    {

        Task<IEnumerable<TaskDTO>> ITaskDAL.GetAllTasksAsync(DbConnection conn)
        {
            var taskSql = @"SELECT Id
                            ,Name
                            ,Description
                            ,StatusId
                            ,AssigneeId
                            ,DueDate
                            FROM dbo.Task";

            return GetDataObjectOfTAsync<TaskDTO>(conn, taskSql);

        }

     
        public async Task<int> AddTask(DbConnection conn, TaskDetailsDTO taskDetails)
        {
            var task = new Task()
            {
                Name = taskDetails.Name,
                Description = taskDetails.Description,
                DueDate = taskDetails.DueDate,
                AssigneeId = taskDetails.PersonAssignedToId,
                StatusId = taskDetails.StatusId
            };

            var taskSql = $@"INSERT INTO dbo.Task
                            (Name
                            ,Description
                            ,StatusId
                            ,AssigneeId
                            ,DueDate)
                            VALUES
                            ({taskDetails.Name}
                            ,{taskDetails.Description}
                            ,{taskDetails.StatusId}
                            ,{taskDetails.PersonAssignedToId}
                            ,{taskDetails.DueDate}
                            );
                            SELECT CAST(scope_identity() AS int);";

            var dbcommond = GetDbCommand(taskSql, conn);
            var taskid = await ExecuteScalarAsync<int>(dbcommond);

            // And using the taskId above insert data into Attachment table
            return taskid;
        }

        public Task<int> DeleteTask(DbConnection conn, int taskId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> EditTask(DbConnection conn, TaskDetailsDTO taskDetails)
        {
            throw new System.NotImplementedException();
        }

      
    }
}