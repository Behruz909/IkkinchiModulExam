using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.Music;

public class Class1
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double MB { get; set; }
    public required string AuthorName { get; set; }

    public string Description { get; set; } = string.Empty;
    public int QuentityLikes { get; set; }
}