using ENG__HUB.API.Entities;

namespace ENG__HUB.API.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAvilable { get; set; }

        //public ICollection<ApplicationUser>? Users { get; set; } // many-to-many
        //public ICollection<Department>? Departments { get; set; } // many-to-many
    }

}
