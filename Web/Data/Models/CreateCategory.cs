using System.ComponentModel.DataAnnotations;

namespace Web.Data.Models;

public class CreateCategory
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    public string? Title { get; set; }
    public string? MetaTitle { get; set; }
    public string? Slug { get; set; }
    public string? Content { get; set; }
}