using Domain.Interfaces;
using Infrastructure.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CategoryRepository(AppDbContext appDbContext): ICategoryRepository
{
    private readonly AppDbContext context = appDbContext;

    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await context.Categories.ToListAsync();
    }
}