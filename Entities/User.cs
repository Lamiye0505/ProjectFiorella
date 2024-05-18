using Microsoft.AspNetCore.Identity;

namespace LoginPage2.Entities
{
	public class User : IdentityUser
	{
        public string FullName { get; set; }
    }
}
