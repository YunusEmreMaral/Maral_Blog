﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Ad Soyad Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail  Adresi  Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Ad en az 2 harften oluşmalıdır");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ad en fazla 50 harften harften oluşmalıdır");
        }
    }
}
