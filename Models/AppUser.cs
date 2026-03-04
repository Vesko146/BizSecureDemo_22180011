namespace BizSecureDemo_22180011.Models;
public class AppUser
{
    public int Id { get; set; }
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = ""; 
}
