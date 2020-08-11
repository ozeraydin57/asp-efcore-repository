using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccsess.DbEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;

        private IPostService _postService;

        public PostController(ILogger<PostController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postService.GetAllPost();
        }

    }
}
