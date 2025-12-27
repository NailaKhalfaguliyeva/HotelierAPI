using FluentValidation;
using Hotelier.Api.WebUI.Dtos.GuestDto;

namespace Hotelier.Api.WebUI.ValidationRules.GuestValidationRules
{
    public class GuestCreateValidator : AbstractValidator<CreateGuestDto>
    {
        public GuestCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The name field cannot be left blank.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("The surname field cannot be left blank.");
            RuleFor(x => x.City).NotEmpty().WithMessage("The city area cannot be left unattended.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter at least 3 characters of data.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Please enter at least 2 characters.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Please enter at least 3 characters of data.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Please enter a maximum of 20 characters.");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Please enter a maximum of 30 characters.");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter a maximum of 20 characters.");
        }
    }
}