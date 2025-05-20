namespace ENG__HUB.API.Entities
{
    public class ApplicationUserCourse
    {
        public string? UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }

        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow; // مثال لخاصية إضافية
    }
}
