using Microsoft.AspNetCore.Identity;

namespace aspDotNet.PresentationLayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} karakter olmalidir"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Parolada en az 1 buyuk harf kullanilmali"
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description="Parolada en az 1 kucuk harf kullanilmali"
			};
		}

		public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUniqueChars",
				Description = $"Parolada {uniqueChars} karakterlerinden herhangi biri bulunmali"
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "Lutfen en az 1 tane rakam giriniz"
			};
		}

		public override IdentityError InvalidEmail(string? email)
		{
			return new IdentityError()
			{
				Code = "InvalidEmail",
				Description = "Lutfen gecerli bir email giriniz"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Sifrenizde ozel karakter bulunmali"
			};
		}

		public override IdentityError PasswordMismatch()
		{
			return new IdentityError()
			{
				Code = "PasswordMismatch",
				Description = "Ayni sifreyi giriniz"
			};
		}
	}
}
