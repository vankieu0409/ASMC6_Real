﻿using ASMC6P.Shared.Entities;

namespace ASMC6P.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        event Action OnChange;
        List<CategoryEntity> Categories { get; set; }
        List<CategoryEntity> AdminCategories { get; set; }
        Task GetCategories();
        Task GetAdminCategories();
        Task AddCategory(CategoryEntity category);
        Task UpdateCategory(CategoryEntity category);
        Task DeleteCategory(int categoryId);
        CategoryEntity CreateNewCategory();
    }
}
