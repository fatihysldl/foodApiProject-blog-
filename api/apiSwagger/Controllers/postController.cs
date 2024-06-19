using businessLayer.abstracts;
using dataAccessLayer.concrete;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postController : ControllerBase
    {
        private readonly IPostService _postService;
        public postController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = _postService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertPost(postTable p)
        {
            _postService.insert(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deletePost(int id)
        {
            var postId = _postService.getById(id);
            _postService.delete(postId);
            return Ok();
        }
        [HttpPut]
        public IActionResult updatePost(int id, postTable p)
        {
            _postService.update(p);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult getPost(int id)
        {
            var values = _postService.getById(id);
            return Ok(values);
        }
    }
}
