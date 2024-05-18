using System.ComponentModel.DataAnnotations;

namespace LoginPage2.VIewModels.Account
{
	public class AccountLoginViewModel
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }
	}
}
