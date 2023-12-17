using Library.Application.Interface;
using Library.Domain.Models;
using Library.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly LalatdigitallibraryContext _context;
        public LibraryService(LalatdigitallibraryContext context)
        {
            _context = context;
        }

        #region AddBook

        /// <summary>
        /// Adds a new book to the database asynchronously.
        /// </summary>
        /// <param name="bookDTO">The data transfer object containing book information.</param>
        /// <returns>
        /// The number of state entries written to the database.
        /// This can be used to determine whether the operation was successful.
        /// </returns>
        /// <remarks>
        /// If the provided <paramref name="bookDTO"/> is null, the method returns 0 immediately.
        /// The method creates a new TblBook entity using the information from the <paramref name="bookDTO"/>.
        /// The TblBook entity is then added to the context, and the changes are saved to the database asynchronously.
        /// The result indicates the number of state entries written to the database.
        /// </remarks>
        public async Task<int> AddBookAsync(BookDTO bookDTO)
        {
            int result = 0;

            // Check if the bookDTO is null, return 0 if so
            if (bookDTO == null)
            {
                return 0;
            }

            try
            {
                // Create a new TblBook entity with information from the bookDTO
                TblBook book = new TblBook()
                {
                    BookName = bookDTO.BookName,
                    Author = bookDTO.Author,
                    Detail = bookDTO.Detail,
                    Price = bookDTO.Price,
                    Publication = bookDTO.Publication,
                    Branch = bookDTO.Branch,
                    Quantities = bookDTO.Quantities,
                    AvlQuantity = bookDTO.AvlQuantity,
                    Images = bookDTO.Images,
                };

                // Add the TblBook entity to the context
                _context.TblBooks.Add(book);

                // Save changes to the database asynchronously
                result = await _context.SaveChangesAsync();

                return result;
            }
            catch (Exception ex)
            {
                // Handle exceptions by rethrowing or logging
                throw;
            }
        }


        #endregion

        #region GetBookList

        /// <summary>
        /// Retrieves a list of books asynchronously from the database.
        /// </summary>
        /// <returns>
        /// A list of <see cref="BookDTO"/> containing book information.
        /// </returns>
        /// <remarks>
        /// The method uses Entity Framework to select books from the TblBooks table.
        /// For each book, a new <see cref="BookDTO"/> is created with relevant information.
        /// The resulting list is returned asynchronously.
        /// </remarks>
        /// <exception cref="Exception">Thrown if an error occurs during the database operation.</exception>
        public async Task<List<BookDTO>> GetBookListAsync()
        {
            try
            {
                List<BookDTO> lst = await _context.TblBooks
                    .Select(b => new BookDTO
                    {
                        BookId = b.BookId,
                        BookName = b.BookName,
                        Author = b.Author,
                        Detail = b.Detail,
                        Price = b.Price,
                        Publication = b.Publication,
                        Branch = b.Branch,
                        Quantities = b.Quantities,
                        AvlQuantity = b.AvlQuantity,
                        RentQuantity = b.RentQuantity,
                        Images = b.Images,
                        Pdf = b.Pdf,
                        CreatedBy = b.CreatedBy
                    })
                    .ToListAsync();

                return lst;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw;
            }
        }

        #endregion


        public async Task<int> UpdateBookAsync(int id, BookDTO bookDTO)
        {
            try
            {
                var tblbookData = _context.TblBooks.FirstOrDefault(x => x.BookId == id);
                if (tblbookData != null)
                {
                    tblbookData.BookName = bookDTO.BookName;
                    tblbookData.Detail = bookDTO.Detail;
                    tblbookData.Author = bookDTO.Author;
                    tblbookData.Price = bookDTO.Price;
                    tblbookData.Publication = bookDTO.Publication;
                    tblbookData.Branch = bookDTO.Branch;
                    tblbookData.Quantities = bookDTO.Quantities;
                    tblbookData.AvlQuantity = bookDTO.AvlQuantity;
                    tblbookData.RentQuantity = bookDTO.RentQuantity;
                    tblbookData.Images = bookDTO.Images;
                  
                }
                _context.Update(tblbookData);
                return await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
