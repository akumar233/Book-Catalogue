using BookCatalogueDTO;
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
