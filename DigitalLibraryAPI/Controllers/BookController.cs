using Library.Application.Interface;
using Library.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DigitalLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        private readonly ILogger<BookController> _logger;
        public BookController(ILibraryService libraryService, ILogger<BookController> logger)
        {
            _libraryService = libraryService;
            _logger = logger;
        }

        [HttpPost("AddBookAsync")]
        public async Task<ActionResult<int>> AddBookAsync(BookDTO request)
        {
            try
            {
                _logger.Log(LogLevel.Information, "AddBookAsync  method called!");
                var result = await _libraryService.AddBookAsync(request).ConfigureAwait(false);
                if (result != null && result > 0)
                {
                    _logger.Log(LogLevel.Information, "AddBookAsync  method results received with count!");
                    return Ok(result);
                }
                else
                {
                    _logger.Log(LogLevel.Information, "No records found!");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, $"Exception in AddBookAsync!{ex.Message}", ex);
                return Problem();
            }
        }

        [HttpPut("UpdateBookAsync")]
        public async Task<ActionResult<int>> UpdateBookAsync(int id,BookDTO request)
        {
            try
            {
                _logger.Log(LogLevel.Information, "AddBookAsync  method called!");
                var result = await _libraryService.UpdateBookAsync(id,request).ConfigureAwait(false);
                if (result != null && result > 0)
                {
                    _logger.Log(LogLevel.Information, "AddBookAsync  method results received with count!");
                    return Ok(result);
                }
                else
                {
                    _logger.Log(LogLevel.Information, "No records found!");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, $"Exception in AddBookAsync!{ex.Message}", ex);
                return Problem();
            }
        }


        [HttpGet("GetBookListAsync")]
        public async Task<ActionResult<List<BookDTO>>> GetBookListAsync()
        {
            try
            {
                _logger.Log(LogLevel.Information, "GetBookListAsync  method called!");
                var result = await _libraryService.GetBookListAsync().ConfigureAwait(false);
                if (result != null)
                {
                    _logger.Log(LogLevel.Information, "GetBookListAsync  method results received with count!");
                    return Ok(result);
                }
                else
                {
                    _logger.Log(LogLevel.Information, "No records found!");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, $"Exception in GetBookListAsync!{ex.Message}", ex);
                return Problem();
            }
        }
        
    }
}
