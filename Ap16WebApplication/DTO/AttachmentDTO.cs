namespace DTO
{
    public class AttachmentDTO
    {
        public int Id { get; set; }

        public int TaskId { get; set; }

        public int TypeId { get; set; }

        public byte[] Content { get; set; }
    }
}