using AutoMapper;
using BookCatalogueDTO;
using DataAccess.Context;
using DataAccess.Entity;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    /// <summary>
    /// This class is a service class for the database transactions.
    /// </summary>
    public class BookCatalogueService : IBookCatalogueServiceInterface
    {
        private readonly BookCatalogueContext _bookCatalogueContext;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor for book catalogue service.
        /// </summary>
        /// <param name="bookCatalogueContext">Dependency inject for book catalogue context.</param>
        public BookCatalogueService(BookCatalogueContext bookCatalogueContext)
        {
            _bookCatalogueContext = bookCatalogueContext;
        }

        /// <summary>
        /// This method is for deleting the book catalogue.
        /// </summary>
        /// <param name="bookDTO">Book catalogue DTO object.</param>
        /// <returns>True/False based on the transaction success.</returns>
        public async Task<bool> DeleteBookCatalogue(BookCatalogueDTOs bookDTO)
        {
            bool returnValue = true;

            var boolCatalogue = _mapper.Map<BookCatalogueDTOs, BookCatalogue>(bookDTO);
            _bookCatalogueContext.BookCatalogues.Remove(boolCatalogue);
            await _bookCatalogueContext.SaveChangesAsync();

            return returnValue;
        }

        /// <summary>
        /// This method is for inserting the book catalogue.
        /// </summary>
        /// <param name="bookDTO">Book catalogue DTO object.</param>
        /// <returns>True/False based on the transaction success.</returns>
        public async Task<bool> InsertBookCatalogue(BookCatalogueDTOs bookDTO)
        {
            bool returnValue = true;

            var boolCatalogue = _mapper.Map<BookCatalogueDTOs, BookCatalogue>(bookDTO);
            _bookCatalogueContext.BookCatalogues.Add(boolCatalogue);
            await _bookCatalogueContext.SaveChangesAsync();

            return returnValue;
        }

        /// <summary>
        /// This method is for updating the book catalogue.
        /// </summary>
        /// <param name="bookDTO">Book catalogue DTO object.</param>
        /// <returns>True/False based on the transaction success.</returns>
        public async Task<bool> UpdateBookCatalogue(BookCatalogueDTOs bookDTO)
        {
            bool returnValue = true;

            var boolCatalogue = _mapper.Map<BookCatalogueDTOs, BookCatalogue>(bookDTO);
            _bookCatalogueContext.BookCatalogues.Update(boolCatalogue);
            await _bookCatalogueContext.SaveChangesAsync();

            return returnValue;
        }
    }
}
