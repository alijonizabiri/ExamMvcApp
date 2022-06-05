using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities;

public class Category
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    [Required,MaxLength(75)]
    public string? Title { get; set; }
    [Required,MaxLength(100)]
    public string? MetaTitle { get; set; }
    [Required,MaxLength(50)]
    public string? Slug { get; set; }
    public string? Content { get; set; }
    public virtual List<PostComment>? PostComments { get; set; }
    public virtual List<PostCategory>? PostCategories { get; set; }
}