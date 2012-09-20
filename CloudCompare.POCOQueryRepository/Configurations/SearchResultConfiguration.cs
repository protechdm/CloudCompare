using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class SearchResultConfiguration : EntityTypeConfiguration<SearchResult>
    {
        public SearchResultConfiguration()
        {
            ToTable("SearchResults");
        }
    }
}
