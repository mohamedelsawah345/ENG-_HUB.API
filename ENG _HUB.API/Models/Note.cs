namespace ENG__HUB.API.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        public string NoteText { get; set; }
        public DateTime CreationDate { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }

}
