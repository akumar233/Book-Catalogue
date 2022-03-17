using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookCatalogueDTO;
using Microsoft.Extensions.Logging;
using System;

namespace BookCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCatalogueAPI : ControllerBase
    {
        private readonly IBookCatalogueDomainService _bookCatalogueDomain;
        private readonly IBookCatalogueServiceInterface _bookCatalogueService;
        private readonly ILogger<BookCatalogueAPI> _logger;

        public BookCatalogueAPI(IBookCatalogueDomainService bookCatalogueDomain, 
            IBookCatalogueServiceInterface bookCatalogueService,
            ILogger<BookCatalogueAPI> logger)
        {
            _bookCatalogueDomain = bookCatalogueDomain;
            _bookCatalogueService = bookCatalogueService;
            _logger = logger;
        }

        [HttpGet]
        [Route("api/BookCatalogues")]
        public IEnumerable<BookCatalogueDTOs> Get()
        {
            try
            {
                _logger.LogInformation("Get request");
                return _bookCatalogueDomain.GetBookCatalogues();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Exception in GET method");
                return null;
            }
        }

        [HttpGet]
        [Route("api/BookCatalogues/Search")]
        public IEnumerable<BookCatalogueDTOs> GetList([FromQuery]BookCatalogueSearchDTO searchDTO)
        {
            try
            {
                _logger.LogInformation("GetList request");
                return _bookCatalogueDomain.GetBookCatalogue(searchDTO);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Exception in GetList method");
                return null;
            }
        }

        [HttpPost]
        public async Task<bool> InsertBookCatalogue(BookCatalogueDTOs bookCatalogue)
        {
            try
            {
                _logger.LogInformation("InsertBookCatalogue request");
                return await _bookCatalogueService.InsertBookCatalogue(bookCatalogue);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Exception in InsertBookCatalogue method");
                return false;
            }
        }

        [HttpDelete]
        public async Task<bool> DeleteBookCatalogue(BookCatalogueDTOs bookCatalogue)
        {
            try
            {
                _logger.LogInformation("DeleteBookCatalogue request");
                return await _bookCatalogueService.DeleteBookCatalogue(bookCatalogue);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Exception in DeleteBookCatalogue method");
                return false;
            }
        }

        [HttpPut]
        public async Task<bool> UpdateBookCatalogue(BookCatalogueDTOs bookCatalogue)
        {
            try
            {
                _logger.LogInformation("UpdateBookCatalogue request");
                return await _bookCatalogueService.UpdateBookCatalogue(bookCatalogue);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Exception in UpdateBookCatalogue method");
                return false;
            }
        }
    }
}
