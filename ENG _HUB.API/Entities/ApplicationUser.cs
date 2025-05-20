using Microsoft.AspNetCore.Identity;

namespace ENG__HUB.API.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string? Major { get; set; }
        public int? DepartmentID { get; set; }
        public Department? Department { get; set; }
        public ICollection<ToDoList>? ToDoLists { get; set; } = new List<ToDoList>();
        public ICollection<Note>? Notes { get; set; } = new List<Note>();

        
        public ICollection<ApplicationUserCourse> UserCourses { get; set; } = new List<ApplicationUserCourse>();
    }
}
