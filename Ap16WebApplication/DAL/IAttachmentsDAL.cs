using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface IAttachmentsDAL
    {
        Task<IEnumerable<AttachmentDTO>> GetAttachments(DbConnection conn);
    }
}