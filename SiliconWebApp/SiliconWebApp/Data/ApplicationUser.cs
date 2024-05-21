using Microsoft.AspNetCore.Identity;

namespace SiliconWebApp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
	public string? UserProfileId { get; set; }
	public UserProfile? UserProfile { get; set; }
	public string? UserAddressId { get; set; }
	public UserAddress? UserAddress { get; set; }
}