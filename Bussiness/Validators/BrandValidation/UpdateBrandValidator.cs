using Bussiness.Dtos.Requests.BrandRequest;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Bussiness.Validators.BrandValidation;

public class UpdateBrandValidator: AbstractValidator<UpdateBrandDto>
{
    public UpdateBrandValidator()
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
