using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class recipeTable
    {
        [Key]
        public int RecipeId { get; set; }
        [StringLength(20)]
        public string RecipeHeader { get; set; }
        [MaxLength]
        public string RecipeValue { get; set; }

        [StringLength(100)]
        public string RecipeIngredients { get; set; }

        [StringLength(150)]
        public string ımagePath { get; set; }
        public List<postTable>? Posts { get; set; }
    }
}
