namespace ENG__HUB.API.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePhoto { get; set; }
        public string Major { get; set; }
        public string Role { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public ICollection<ToDoList> ToDoLists { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<PromptHistory> PromptHistories { get; set; }
        public ICollection<Course> Courses { get; set; } // many-to-many
    }

}
