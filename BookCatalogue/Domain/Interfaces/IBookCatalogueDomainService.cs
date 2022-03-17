using BookCatalogueDTO;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interface of book catalogue domain service.
    /// </summary>
    public interface IBookCatalogueDomainService
    {
        List<BookCatalogueDTOs> GetBookCatalogues();
        List<BookCatalogueDTOs> GetBookCatalogue(BookCatalogueSearchDTO searchDTO);
    }
}
