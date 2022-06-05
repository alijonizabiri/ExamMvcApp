using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities;

public class PostMeta
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
    [Required,MaxLength(50)]
    public string? Key { get; set; }
}