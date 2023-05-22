using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookInformationApp.API.Domain_Entities;
using BookInformationApp.API.Interfaces;
using BookInformationApp.API.DTOs;
using AutoMapper;
using static System.Reflection.Metadata.BlobBuilder;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Authorization;

namespace BookInformationApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;
        private readonly IMapper _mapper;

        public BooksController(IBookRepository bookRepository,IMapper mapper)
        {
            this._bookRepo = bookRepository;
            this._mapper = mapper;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAllBooks()
        {
            var books = await _bookRepo.GetAllAsync();
            if(books == null || !books.Any())
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IList<BookDto>>(books));
        }

        // GET: api/Books/1
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<BookDto>> GetBookById(int id)
        {
            var book = await _bookRepo.GetByIdAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<BookDto>(book));
        }

        // GET: api/Books/genre
        [HttpGet("genre")]
        [Authorize]
        public async Task<ActionResult<BookDto>> GetBookByName(string genre)
        {
            if(String.IsNullOrEmpty(genre))
            {
                return BadRequest("Invalid Genre !!!");
            }
            var books = await _bookRepo.GetBooksByGenreAsync(genre);

            if (books == null || !books.Any())
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IList<BookDto>>(books));
        }


        // PUT: api/Books/3
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateBook(int id, BookDto bookDetails)
        {
            if (id != bookDetails.Id)
            {
                return BadRequest("Invalid book ID !!!");
            }

            var book = await _bookRepo.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _mapper.Map(bookDetails,book);

            try
            {
                await _bookRepo.UpdateAsync(book);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<BookDto>> AddBook(BookCreateDto bookDetails)
        {
            var book = _mapper.Map<Book>(bookDetails);
            await _bookRepo.AddAsync(book);

            return CreatedAtAction("GetBookById", new { id = book.Id }, bookDetails);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _bookRepo.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            await _bookRepo.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> BookExists(int id)
        {
            return await _bookRepo.Exists(id);
        }
    }
}
