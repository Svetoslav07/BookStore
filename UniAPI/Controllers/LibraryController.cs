using BookStore.BL.Interfaces;
using BookStore.Models.Models;
using BookStore.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace UniAPI.Controllers;

[ApiController]
[Route("[controller]")]


public class LibraryController : Controller
{
    private readonly ILogger<AuthorController> _logger;
    private readonly IAuthorService _authorService;

    public LibraryController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet("GetById")]
    public Author GetById(int id)
    {
        return _authorService.GetById(id);
    }

} 
