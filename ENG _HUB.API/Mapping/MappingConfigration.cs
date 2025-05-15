using ENG__HUB.API.Contract.Courses;
using ENG__HUB.API.Contract.Departments;
using ENG__HUB.API.Contract.Note;

namespace ENG__HUB.API.Mapping
{
    public class MappingConfigration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Course, CourseResponse>()
            .Map(dest => dest.ID, src => src.ID);

            config.NewConfig<Department, DepartmentResponse>()
           .Map(dest => dest.ID, src => src.ID);

            

        }
    }
}
