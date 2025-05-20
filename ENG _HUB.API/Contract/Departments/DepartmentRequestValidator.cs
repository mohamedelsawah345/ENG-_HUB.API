using ENG__HUB.API.Contract.Courses;

namespace ENG__HUB.API.Contract.Departments
{
    public class DepartmentRequestValidator : AbstractValidator<DepartmentRequest>
    {
        public DepartmentRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(2, 100);

            

        }
    }
    
}
