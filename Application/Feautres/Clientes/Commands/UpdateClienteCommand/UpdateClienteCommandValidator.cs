using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feautres.Clientes.Commands.UpdateClienteCommand
{
    public class UpdateClienteCommandValidator : AbstractValidator<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidator()
        {
           RuleFor(p => p.Id)
               .NotEmpty().WithMessage("{PropertyId} no pueder ser vacio. ");

            //RuleFor(r => r.Id).NotEmpty().WithMessage("{PropertyName} cannot be empty");

            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no pueder ser vacio. ")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres. ");

            RuleFor(p => p.Apellido)
               .NotEmpty().WithMessage("{PropertyName} no pueder ser vacio. ")
               .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres. ");

            RuleFor(p => p.FechaNacimiento)
               .NotEmpty().WithMessage("Fecha de Nacimineto no pueder ser vacia. ");

            RuleFor(p => p.Telefono)
              .NotEmpty().WithMessage("{PropertyName} no pueder ser vacio. ")
              // .Matches(@"^\d{10}$").WithMessage("{PropertyName} debe cumplir con el formato 00-0000-0000" )
              .MaximumLength(10).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres. ");

            RuleFor(p => p.Email)
             .NotEmpty().WithMessage("{PropertyName} no pueder ser vacio. ")
             .EmailAddress().WithMessage("{PropertyName} debe ser una dierccion de Email valida. ")
             .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres. ");

            RuleFor(p => p.Direccion)
             .NotEmpty().WithMessage("{PropertyName} no pueder ser vacio. ")
             .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres. ");
        }

    }
}
