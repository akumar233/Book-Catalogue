using AutoMapper;
using BookCatalogueDTO;

namespace BookCatalogue.Infrastructure
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BookCatalogueDTOs, DataAccess.Entity.BookCatalogue>();
            CreateMap<DataAccess.Entity.BookCatalogue, BookCatalogueDTOs>();
        }
    }
}
