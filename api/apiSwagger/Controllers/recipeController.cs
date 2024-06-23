using businessLayer.abstracts;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class recipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public recipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var values = _recipeService.getAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult insertRecipe(recipeTable p)
        {
            _recipeService.insert(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteRecipe(int id)
        {
            var recipeId = _recipeService.getById(id);
            _recipeService.delete(recipeId);
            return Ok();
        }
        [HttpPut]
        public IActionResult updateRecipe(int id, recipeTable p)
        {
            _recipeService.update(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getRecipe(int id)
        {
            var values = _recipeService.getById(id);
            return Ok(values);
        }
    }
}
