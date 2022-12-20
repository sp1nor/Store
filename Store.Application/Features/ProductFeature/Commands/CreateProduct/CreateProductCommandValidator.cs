using FluentValidation;
using System.Linq;

namespace Store.Application.Features.ProductFeature.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            var msg = "Ошибка в поле {PropertyName}: значение {PropertyValue}";

            _ = RuleFor(c => c.Name)
                .NotEmpty().WithMessage(msg)
                .Must(c => c.All(char.IsLetter)).WithMessage(msg);
        }
    }
}
