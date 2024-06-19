using businessLayer.abstracts;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public authorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var values = _authorService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertAuthor(authorTable p)
        {
            _authorService.insert(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteAuthor(int id)
        {
            var authorId = _authorService.getById(id);
            _authorService.delete(authorId);
            return Ok();
        }
        [HttpPut]
        public IActionResult updateAuthor(int id,authorTable p)
        {
            _authorService.update(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult getAuthor(int id)
        {
            var values = _authorService.getById(id);
            return Ok(values);
        }
    }
}
