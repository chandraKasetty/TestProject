﻿using System;

namespace DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public DateTime DueDate { get; set; }
        public int AssigneeId { get; set; }

    }
}
