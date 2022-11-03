using System.Security.Claims;
using FluentValidation;
using VeterinaryDb.Models;

namespace SchoolDemo.Validators
{
    public class OwnerValidator : AbstractValidator<Owner>
    {
        public OwnerValidator()
        {
            RuleFor(firstname => firstname.FirstName).NotNull().WithMessage("Please enter your first name");
            RuleFor(firstname => firstname.FirstName).NotNull().WithMessage("Please enter your last name");

        }
    }
}


