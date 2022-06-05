using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities;

public class PostComment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
    public int ParentId { get; set; }
    [Required,MaxLength(50)]
    public string? Title { get; set; }
    public int Published { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime PublishedAt { get; set; }
    public string? Content { get; set; }
}