using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities;

public class Tag
{
    public int Id { get; set; }
    [Required,MaxLength(75)]
    public string? Title { get; set; }
    [Required,MaxLength(100)]
    public string? MetaTitle { get; set; }
    [Required,MaxLength(50)]
    public string? Slug { get; set; }
    public string? Content { get; set; }
    public virtual List<PostTag>? PostTags { get; set; }
}