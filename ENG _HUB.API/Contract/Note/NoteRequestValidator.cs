namespace ENG__HUB.API.Contract.Note
{
    public class NoteRequestValidator : AbstractValidator<NoteRequest>
    {
        public NoteRequestValidator()
        {
            RuleFor(x => x.Text)
                .NotEmpty();
            RuleFor(x => x.CreationDate).
                NotEmpty();






        }
    }


}
