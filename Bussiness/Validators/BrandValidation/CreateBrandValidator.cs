using Bussiness.Dtos.Requests.BrandRequest;
using FluentValidation;

namespace Bussiness.Validators.BrandValidation;

public sealed class CreateBrandValidator : AbstractValidator<CreateBrandDto>
{
    public CreateBrandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
                .WithMessage("İsim Boş Geçilemez..")
            .MinimumLength(2)
                .WithMessage("İsim minimum 2 karakter olmalı.")
            .MaximumLength(20)
                .WithMessage("İsim maksimum 20 karakterde olmalı.");
    }
}
