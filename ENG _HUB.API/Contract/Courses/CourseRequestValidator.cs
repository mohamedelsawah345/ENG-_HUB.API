namespace ENG__HUB.API.Contract.Courses
{
    public class CourseRequestValidator : AbstractValidator<CourseRequest>
    {
        public CourseRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(2, 100);

            RuleFor(x => x.IsAvilable)
                .NotNull()
                .WithMessage("IsAvilable must be true or false");

        }
    }
}
