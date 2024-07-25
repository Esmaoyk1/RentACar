using Bussiness.Dtos.Requests.OrderRequest;
using FluentValidation;

namespace Bussiness.Validators.OrderValidation;

public class UpdateOrderValidator : AbstractValidator<UpdateOrderDto>
{
    public UpdateOrderValidator()
    {
        RuleFor(x => x.TerceDate)
                .NotEmpty()
                    .WithMessage("Tarih bos geçilmesin");



        RuleFor(x => x.DeliveryDate)
            .NotEmpty()
                .WithMessage("Tarih bos geçilmesin");

    }
}
