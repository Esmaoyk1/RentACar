using Bussiness.Dtos.Requests.CarRequest;
using Bussiness.Dtos.Requests.ModelRequest;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using Microsoft.JSInterop;
using System.Globalization;

namespace Bussiness.Validators.CarValidation;

public class CreateCarValidator : AbstractValidator<CreateCarDto>
{
    public CreateCarValidator()
    {
        RuleFor(x => x.DailyPrice)
            .NotEmpty()
                .WithMessage("Günlük ücret girilmeli")
            .InclusiveBetween(1000, 5000)
                .WithMessage("Günlük ücret 1000 TL ile 5000 TL arasında olmalıdır.");

        //RuleFor(x => new { x.Transmission, x.FuelType, x.RentalStatus })
        //    .Empty()
        //        .WithMessage("Transmission, FuelType ve RentalStatus alanlarının hepsi dolu olmalıdır.");



        //RuleFor(x => x.Year)
     
        //    .Must(y => int.TryParse(y.ToString(), out _))
        //        .WithMessage("Yıl alanına sayısal bir değer giriniz.");







    }





}


