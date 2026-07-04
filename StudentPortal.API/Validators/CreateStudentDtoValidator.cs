using FluentValidation;
using StudentPortal.API.DTOs;

namespace StudentPortal.API.Validators
{
    public class CreateStudentDtoValidator : AbstractValidator<CreateStudentDto>
    {
        public CreateStudentDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Invalid email address");

            RuleFor(x => x.Age)
                .InclusiveBetween(18, 60)
                .WithMessage("Age must be between 18 and 60");

            RuleFor(x => x.Department)
                .NotEmpty()
                .WithMessage("Department is required");
        }
    }
}