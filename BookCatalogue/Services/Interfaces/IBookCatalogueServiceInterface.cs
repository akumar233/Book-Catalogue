using BookCatalogueDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookCatalogueServiceInterface
    {
        Task<bool> InsertBookCatalogue(BookCatalogueDTOs bookDTO);
        Task<bool> DeleteBookCatalogue(BookCatalogueDTOs bookDTO);
        Task<bool> UpdateBookCatalogue(BookCatalogueDTOs bookDTO);
    }
}
