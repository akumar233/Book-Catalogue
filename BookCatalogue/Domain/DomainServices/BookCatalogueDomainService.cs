using AutoMapper;
using BookCatalogueDTO;
using DataAccess.Context;
using DataAccess.Entity;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.DomainServices
{
    /// <summary>
    /// This class is a domain service service class for getting the records from database.
    /// </summary>
    public class BookCatalogueDomainService : IBookCatalogueDomainService
    {
        private readonly BookCatalogueContext _bookCatalogueContext;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor for book catalogue domain service.
        /// </summary>
        /// <param name="bookCatalogueContext">Dependency inject for book catalogue context.</param>
        public BookCatalogueDomainService(BookCatalogueContext bookCatalogueContext)
        {
            _bookCatalogueContext = bookCatalogueContext;
        }

        /// <summary>
        /// This method is searching the book catalogue base on search parameters.
        /// </summary>
        /// <param name="searchDTO">Search parameter either title, author or ISBN number (13 digit).</param>
        /// <returns>Searched book catalog list.</returns>
        public List<BookCatalogueDTOs> GetBookCatalogue(BookCatalogueSearchDTO searchDTO)
        {
            List<BookCatalogueDTOs> bookCatalogueDTOs = new List<BookCatalogueDTOs>();
            IQueryable<BookCatalogue> bookCatalogueList;

            if (searchDTO != null && searchDTO.Title != null)
            {
                bookCatalogueList = _bookCatalogueContext.BookCatalogues.Where(x => x.Title == searchDTO.Title);
            }
            else if (searchDTO != null && searchDTO.Authors != null)
            {
                bookCatalogueList = _bookCatalogueContext.BookCatalogues.Where(x => x.Authors == searchDTO.Authors);
            }
            else if (searchDTO != null && searchDTO.ISBN != null)
            {
                bookCatalogueList = _bookCatalogueContext.BookCatalogues.Where(x => x.ISBN == searchDTO.ISBN);
            }
            else
            {
                return GetBookCatalogues();
            }

            bookCatalogueDTOs = _mapper.Map<List<BookCatalogue>, List<BookCatalogueDTOs>>(bookCatalogueList.ToList());

            return bookCatalogueDTOs;
        }

        /// <summary>
        /// This method is returning the complete book catalogue list.
        /// </summary>
        /// <returns>Book catalogue list.</returns>
        public List<BookCatalogueDTOs> GetBookCatalogues()
        {
            List<BookCatalogueDTOs> bookCatalogueDTOs = new List<BookCatalogueDTOs>();

            IQueryable<BookCatalogue> bookCatalogueList = _bookCatalogueContext.BookCatalogues;
            bookCatalogueDTOs = _mapper.Map<List<BookCatalogue>, List<BookCatalogueDTOs>>(bookCatalogueList.ToList());

            return bookCatalogueDTOs;
        }
    }
}
