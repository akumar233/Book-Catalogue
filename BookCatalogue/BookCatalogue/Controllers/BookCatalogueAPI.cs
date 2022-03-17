using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCatalogueDTO;

namespace BookCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCatalogueAPI : ControllerBase
    {
        private readonly IBookCatalogueDomainService _bookCatalogueDomain;
        private readonly IBookCatalogueServiceInterface _bookCatalogueService;

        public BookCatalogueAPI(IBookCatalogueDomainService bookCatalogueDomain, 
            IBookCatalogueServiceInterface bookCatalogueService)
        {
            _bookCatalogueDomain = bookCatalogueDomain;
            _bookCatalogueService = bookCatalogueService;
        }

        [HttpGet]
        [Route("api/BookCatalogues")]
        public IEnumerable<BookCatalogueDTOs> Get()
        {
            return _bookCatalogueDomain.GetBookCatalogues();
        }

        [HttpGet]
        [Route("api/BookCatalogues/Search")]
        public IEnumerable<BookCatalogueDTOs> GetList([FromQuery]BookCatalogueSearchDTO searchDTO)
        {
            return _bookCatalogueDomain.GetBookCatalogue(searchDTO);
        }

        [HttpPost]
        public async Task<bool> InsertBookCatalogue(BookCatalogueDTOs bookCatalogue)
        {
            return await _bookCatalogueService.InsertBookCatalogue(bookCatalogue);
        }

        [HttpDelete]
        public async Task<bool> DeleteBookCatalogue(BookCatalogueDTOs bookCatalogue)
        {
            return await _bookCatalogueService.DeleteBookCatalogue(bookCatalogue);
        }

        [HttpPut]
        public async Task<bool> UpdateBookCatalogue(BookCatalogueDTOs bookCatalogue)
        {
            return await _bookCatalogueService.UpdateBookCatalogue(bookCatalogue);
        }
    }
}
