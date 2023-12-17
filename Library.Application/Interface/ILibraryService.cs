using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Interface
{
    public interface ILibraryService
    {
        Task<List<BookDTO>> GetBookListAsync();
        Task<int> AddBookAsync(BookDTO bookDTO);
        Task<int> UpdateBookAsync(int id, BookDTO bookDTO);
    }
}
