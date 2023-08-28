namespace Domain;

public class BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string PhoneNumber { get; set; }
    public bool Active { get; set; }
    
}