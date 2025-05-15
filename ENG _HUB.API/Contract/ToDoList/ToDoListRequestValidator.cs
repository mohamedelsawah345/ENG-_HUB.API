

namespace ENG__HUB.API.Contract.ToDoList
{
    public class ToDoListRequestValidator : AbstractValidator<ToDoListRequest>
    {
        public ToDoListRequestValidator()
        {
            RuleFor(x => x.Text)
                .NotEmpty();
            RuleFor(x => x.CreationDate).
                NotEmpty();
            RuleFor(x => x.DeadLineDate)
                .NotEmpty()
                .GreaterThan(x => x.CreationDate)
                .WithMessage("Deadline date must be after than creation date.");
        }
    }
}
