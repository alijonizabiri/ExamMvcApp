using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entities;

public class Post
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public User User { get; set; }
    public int ParentId { get; set; }
    [Required,MaxLength(50)]
    public string? Title { get; set; }
    [Required,MaxLength(75)]
    public string? MetaTitle { get; set; }
    [Required,MaxLength(100)]
    public string? Slug { get; set; }
    public string? Sumary { get; set; }
    public int Published { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime PublishedAt { get; set; }
    public string? Content { get; set; }
    public virtual List<PostComment>? PostComments { get; set; }
    public virtual List<PostMeta>? PostMetas { get; set; }
    public virtual List<PostCategory>? PostCategories { get; set; }
    public virtual List<PostTag>? PostTags { get; set; }
    
}