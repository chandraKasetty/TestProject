using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AttachmentsDAL: AP16Database, IAttachmentsDAL
    {
        public async Task<IEnumerable<AttachmentDTO>> GetAttachments(DbConnection conn)
        {

            var sql = @"SELECT Id
                                ,TaskId
                                ,Value
                                ,TypeId
                                FROM Attachments";

            return await GetDataObjectOfTAsync<AttachmentDTO>(conn, sql);
        }
    }
}