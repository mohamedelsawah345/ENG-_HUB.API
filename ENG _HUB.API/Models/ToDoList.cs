namespace ENG__HUB.API.Models
{
    public class ToDoList
    {
        public int ToDoListID { get; set; }
        public string ToDoText { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DeadLineDate { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }

}
