using System.Net;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Data.Entities;
using Web.Data.Models;

namespace Web.Services;

public class CategoryServices
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CategoryServices(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> InsertCategory(CreateCategory category)
    {
        var get = _mapper.Map<Category>(category);
        await _context.Categories.AddAsync(get);
        return _context.SaveChanges();
    }
    
    public async Task<int> UpdateCategory(CreateCategory category)
    {
        var find =  await _context.Categories.FindAsync(category.Id);
        find.Title = category.Title;
        find.MetaTitle = category.MetaTitle;
        find.ParentId = category.ParentId;
        find.Slug = category.Slug;
        find.Content = category.Content;
        return _context.SaveChanges();
    }
    
    public async Task<List<CreateCategory>> GetCategories()
    {
        var category = await (from c in _context.Categories
            select new CreateCategory
            {
                Id = c.Id,
                Title = c.Title,
                MetaTitle = c.MetaTitle,
                Slug = c.Slug,
                ParentId = c.ParentId,
                Content = c.Content
            }).ToListAsync();
        return category;

    }
    
    public async Task<CreateCategory> GetCategoryById(int id)
    {
        var category = await (from c in _context.Categories
            where c.Id == id
            select new CreateCategory
            {
                Id = c.Id,
                Title = c.Title,
                MetaTitle = c.MetaTitle,
                Slug = c.Slug,
                ParentId = c.ParentId,
                Content = c.Content
            }).FirstOrDefaultAsync();
        return category;

    }
    
    public async Task<int> DeleteCategory(int id)
    {
        var find = await _context.Categories.FindAsync(id);
        _context.Categories.Remove(find);
        return _context.SaveChanges();

    }
    
}