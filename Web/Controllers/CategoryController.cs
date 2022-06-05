using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data.Entities;
using Web.Data.Models;
using Web.Services;

namespace Web.Controllers;

public class CategoryController : Controller
{
    private readonly CategoryServices _categoryServices;

    public CategoryController(CategoryServices categoryServices)
    {
        _categoryServices = categoryServices;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await _categoryServices.GetCategories());   
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View(new CreateCategory());
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateCategory category)
    {
        if (ModelState.IsValid == true)
        {
            await _categoryServices.InsertCategory(category);
            return RedirectToAction(nameof(Index));
        }

        return View(category);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var get = await _categoryServices.GetCategoryById(id);
        return View(get);
    }
    
    [HttpPost]
    public async Task<IActionResult> Edit(CreateCategory category)
    {
        if (ModelState.IsValid == false) return View(category);
        try
        {
            await _categoryServices.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, $"Something went wrong {ex.Message}");
            return View(category);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        await _categoryServices.DeleteCategory(id);
        return RedirectToAction("Index");
    }

}