using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       
        private readonly ILogger<AuthorController> _logger;
        public readonly IAuthorService_authorService;

            public AuthorController(ILogger<AuthorController>logger)



        {
            _logger = logger;
            _authorService = _authorService;
        }

        [HttpGet(Name = "GetAllAuthors")]
        public IEnumerable<Author> GetAll()
        {
            return_authorService.GetALL();
        }
    }
}