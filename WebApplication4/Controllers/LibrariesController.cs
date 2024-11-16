using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models.Entities;


namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrariesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LibrariesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]

        public IActionResult AddBook(Book addbookDto)
        {
            var BookEntity = new Book()
            {
                Title = addbookDto.Title,
                Description = addbookDto.Description,
                PublicationYear = addbookDto.PublicationYear,
                CategoryId = addbookDto.CategoryId,
                AuthorId = addbookDto.AuthorId,
            };

            context.Books.Add(BookEntity);
            context.SaveChanges();
            return Ok(BookEntity);
        }
        [HttpGet]
        public IActionResult GetData()
        {
            var allBooks = context.Books.ToList();
            return Ok(allBooks);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);

        }

        
    }
}
