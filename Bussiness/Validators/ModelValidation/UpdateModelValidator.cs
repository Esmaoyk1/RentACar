using Bussiness.Dtos.Requests.ModelRequest;
using FluentValidation;

namespace Bussiness.Validators.ModelValidation;

public class UpdateModelValidator: AbstractValidator<UpdateModelDto>
{
    public UpdateModelValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
                .WithMessage("İsim Boş Geçilemez")
            .MinimumLength(2)
                .WithMessage("İsim minimum 2 karakter olmalı.")
            .MaximumLength(20)
                .WithMessage("İsim maksimum 20 karakterde olmalı.");
    }
}
