using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities;

public class User
{
    public int Id { get; set; }
    [Required,MaxLength(30)]
    public string? FirstName { get; set; }
    [Required,MaxLength(30)]
    public string? MiddleName { get; set; }
    [Required,MaxLength(30)]
    public string? LastName { get; set; }
    [Required]
    public string? Mobile { get; set; }
    [Required,MaxLength(30)]
    public string? Email { get; set; }
    [Required,MaxLength(30)]
    public string? PasswordHash { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime LastLogin { get; set; }
    public string? Intro { get; set; }
    public string? Profile { get; set; }
    public virtual List<Post>? Posts { get; set; }
}