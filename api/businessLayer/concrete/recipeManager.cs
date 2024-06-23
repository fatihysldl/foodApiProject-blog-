using businessLayer.abstracts;
using dataAccessLayer.abstracts;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.concrete
{
    public class recipeManager : IRecipeService
    {
        IRecipeDal _recipe;

        public recipeManager(IRecipeDal recipe)
        {
            _recipe = recipe;
        }

        public void delete(recipeTable p)
        {
            _recipe.delete(p);
        }

        public List<recipeTable> getAll()
        {
            return _recipe.getAll();
        }

        public recipeTable getById(int id)
        {
            return _recipe.getById(id);
        }

        public void insert(recipeTable p)
        {
            _recipe.insert(p);
        }

        public List<recipeTable> List(Expression<Func<recipeTable, bool>> filter)
        {
            return _recipe.List(filter);
        }

        public void update(recipeTable p)
        {
            _recipe.update(p);
        }
    }
}
