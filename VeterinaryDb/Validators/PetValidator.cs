
using FluentValidation;
using VeterinaryDb.Models;

namespace SchoolDemo.Validators
{
    public class PetValidator : AbstractValidator<Pet>
    {
        public PetValidator()
        {
            RuleFor(name => name.PetName).NotNull().WithMessage("Please enter your pet's name");
            RuleFor(species => species.Species).NotNull().WithMessage("Please enter pet species");

        }
    }
}

