using FluentValidation;

namespace Lab.DTOs.Validators
{
    public class AddProductDTOValidator: AbstractValidator<AddProductDTO>
    {
        public AddProductDTOValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.IsAvailable).NotEmpty();
        }
    }
}
