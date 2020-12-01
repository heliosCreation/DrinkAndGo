using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Mocks
{
    public class MockCategoryRepository 
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category{Name="Alcoholic", Description="All the alcoholic drinks"},
                new Category{Name="Non Alcoholic", Description = "All the non-alcoholic drinks"}
            };
        }
    }
}
