using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class BookCatalogueContext: DbContext, IBookCatalogueContext
    {
        public BookCatalogueContext(DbContextOptions<BookCatalogueContext> options):base(options)
        {

        }

        public DbSet<BookCatalogue> BookCatalogues { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
