using Application.DTOs.Account;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Tests.Identity
{
    public class RegisterValidation
    {
        private readonly RegisterRequestValidator _validator;

        public RegisterValidation()
        {
            _validator = new RegisterRequestValidator();
        }

        [Fact]
        public void Should_have_error_when_FirstName_is_null()
        {
            var model = new RegisterRequest { FirstName = null };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.FirstName);
        }

        [Fact]
        public void Should_Not_have_error_when_FirstName_is_null()
        {
            var model = new RegisterRequest { FirstName = "Piotr" };

            _validator.TestValidate(model).ShouldNotHaveValidationErrorFor(x => x.FirstName);
        }

        [Fact]
        public void Should_have_error_when_LastName_is_null()
        {
            var model = new RegisterRequest { LastName = null };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.LastName);
        }

        [Fact]
        public void Should_Not_have_error_when_LastName_is_null()
        {
            var model = new RegisterRequest { LastName = "Kowalski" };

            _validator.TestValidate(model).ShouldNotHaveValidationErrorFor(x => x.LastName);
        }

        [Fact]
        public void Should_have_error_when_Email_is_null()
        {
            var model = new RegisterRequest { Email = null };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.Email);
        }

        [Fact]
        public void Should_Not_have_error_when_Email_is()
        {
            var model = new RegisterRequest { Email = "kowalski@wp.pl" };

            _validator.TestValidate(model).ShouldNotHaveValidationErrorFor(x => x.Email);
        }

        [Fact]
        public void Should_Not_have_error_when_Password_Compare_ConfirmPassword()
        {
            var model = new RegisterRequest { Password = "Test123", ConfirmPassword = "Test123" };

            _validator.TestValidate(model).ShouldNotHaveValidationErrorFor(x => x.Password);
        }

        [Fact]
        public void Should_have_error_when_Password_Compare_Not_ConfirmPassword()
        {
            var model = new RegisterRequest { Password = "Test123", ConfirmPassword = "Tes" };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.Password);
        }


        [Fact]
        public void Should_have_error_when_UserName_is_null()
        {
            var model = new RegisterRequest { UserName=null };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.UserName);
        }

        [Fact]
        public void Should_have_error_when_UserName_Leng_is()
        {
            var model = new RegisterRequest { UserName = "1234" };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.UserName);
        }

        [Fact]
        public void Should_have_error_when_Password_is_null()
        {
            var model = new RegisterRequest { Password = null };

            _validator.TestValidate(model).ShouldHaveValidationErrorFor(x => x.Password);
        }

        [Fact]
        public void Should_Not_have_error_when_UserName_is()
        {
            var model = new RegisterRequest { UserName = "Piotr1" };

            _validator.TestValidate(model).ShouldNotHaveValidationErrorFor(x => x.UserName);
        }

    }
}
