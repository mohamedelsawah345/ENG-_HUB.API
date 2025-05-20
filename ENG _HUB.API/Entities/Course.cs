using ENG__HUB.API.Entities;

namespace ENG__HUB.API.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAvilable { get; set; }

        public int? DepartmentID { get; set; } // foreign key
        public Department? Department { get; set; } // one-to-many

        


        public ICollection<ApplicationUserCourse> UserCourses { get; set; } = new List<ApplicationUserCourse>();

    }

}
