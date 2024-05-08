using EZParking.Common.Validations;

namespace EZParking.Domain.Errors
{
    public static class DomainErrors
    {
        public static class Teste
        {
            public static readonly Error EmptyName = new(
                "ApplicationUser.Name",
                "Name is empty");

            public static readonly Error EmptyEmail = new(
                "ApplicationUser.Email",
                "Email is empty");

            public static readonly Error EmptyPass = new(
                "ApplicationUser.Password",
                "Password is empty");
        }
    }
}
