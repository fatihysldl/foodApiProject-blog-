using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class postTable
    {
        [Key]
        public int postId { get; set; }
        [StringLength(20)]
        public string postHeader { get; set; }

        [StringLength(10)]
        public string postDate { get; set; }

        [StringLength(100)]
        public string postDescription { get; set; }

        public int authorId { get; set; }
        public authorTable? Author { get; set; }

        [ForeignKey("RecipeId")]
        public recipeTable? Recipe { get; set; }
    }
}
