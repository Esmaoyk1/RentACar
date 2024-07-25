using Bussiness.Dtos.Requests.CarRequest;
using FluentValidation;

namespace Bussiness.Validators.CarValidation;

public class UpdateCarValidation : AbstractValidator<UpdateCarDto>
{
    public UpdateCarValidation()
    {
        RuleFor(x => x.DailyPrice)
            .NotEmpty()
                .WithMessage("Günlük ücret girilmeli")
            .InclusiveBetween(1000, 5000)
                .WithMessage("Günlük ücret 1000 TL ile 5000 TL arasında olmalıdır.");

        RuleFor(x => new { x.Transmission, x.FuelType, x.RentalStatus })
            .Empty()
                .WithMessage("Transmission, FuelType ve RentalStatus alanlarının hepsi dolu olmalıdır.");

    }
}
