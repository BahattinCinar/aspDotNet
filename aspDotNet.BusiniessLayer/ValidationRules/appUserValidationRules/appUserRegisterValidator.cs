using aspDotNet.EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aspDotNet.DtoLayer.Dtos.appUserDtos;

namespace aspDotNet.BusiniessLayer.ValidationRules.AppUserValidationRules
{
    public class appUserRegisterValidator : AbstractValidator <appUserRegisterDto>
    {
        public appUserRegisterValidator()
        {
            RuleFor(x => x.dtoName).NotEmpty().WithMessage("Ad kismi bos gecilemez");
            RuleFor(x => x.dtoSurname).NotEmpty().WithMessage("Soyisim kismi bos gecilemez");
            RuleFor(x => x.dtoEmail).NotEmpty().WithMessage("Email kismi bos gecilemez");
            RuleFor(x => x.dtoPassword).NotEmpty().WithMessage("Sifre kismi bos gecilemez");
            RuleFor(x => x.dtoConfirmPassword).NotEmpty().WithMessage("Sifreyi tekrarlayiniz");

            RuleFor(x => x.dtoPassword).MinimumLength(7).WithMessage("Minimum uzunluk 7 olmalidir");
            RuleFor(x=>x.dtoConfirmPassword).Equal(y=> y.dtoPassword).WithMessage("Parolalar ayni degil");
            RuleFor(x => x.dtoEmail).EmailAddress().WithMessage("Lutfen Gecerli bir mail adresi giriniz");
        }
    }
}
