using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class TabbedSearchResultsConfiguration : EntityTypeConfiguration<TabbedSearchResults>
    {
        public TabbedSearchResultsConfiguration()
        {
            ToTable("TabbedSearchResults");
        }
    }
}
