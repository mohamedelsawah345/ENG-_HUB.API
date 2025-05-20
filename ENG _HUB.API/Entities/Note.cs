using ENG__HUB.API.Entities;

namespace ENG__HUB.API.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string? UserID { get; set; } = string.Empty; // ✅ ID نوعه string
        public ApplicationUser? User { get; set; }
    }

}
