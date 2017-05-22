using System;
using System.Collections.Generic;

namespace DTO
{
    public class TaskDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public StatusDTO Status { get; set; }
        public DateTime DueDate { get; set; }
        public string PersonAssignedTo { get; set; }
        public int PersonAssignedToId { get; set; }

        public List<AttachmentDTO> Attachments { get; set; }

    }
}