using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface IRecipeService
    {
        void insert(recipeTable p);
        void update(recipeTable p);
        void delete(recipeTable p);
        List<recipeTable> getAll();
        recipeTable getById(int id);

        List<recipeTable> List(Expression<Func<recipeTable, bool>> filter);
    }
}
