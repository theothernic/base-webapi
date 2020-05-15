using System.Data;
using Api.Areas.User.Dtos;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.User.Validators
{
    public class UserRegisterDtoValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterDtoValidator()
        {
            RuleFor(d => d.Name).NotEmpty();
            RuleFor(d => d.Email).NotEmpty().EmailAddress();
            RuleFor(d => d.Password).NotEmpty();
            RuleFor(d => d.PasswordConfirmation)
                .NotEmpty()
                .Equal(d => d.Password);
        }
    }
}