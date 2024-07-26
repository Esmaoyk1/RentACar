using Bussiness.Dtos.Requests.OrderRequest;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Validators.OrderValidation
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderDto>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.TerceDate)
                .NotEmpty()
                    .WithMessage("Tarih bos geçilmesin");


            RuleFor(x => x.DeliveryDate)
                .NotEmpty()
                    .WithMessage("Tarih bos geçilmesin");


            //RuleFor(x => new { x.TerceDate, x.DeliveryDate })
            //    .NotEmpty()
            //        .WithMessage("Tarihler boş geçilmemeli");

        }
    }
}
