using FluentValidation;
using Sun.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sun.Application
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("É necessário um Id");
            RuleFor(c => c.Name).Length(0, 150).WithMessage("A cidade deve ter um nome com menos de 150 caractéres");
        }
    }
}
