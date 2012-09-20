using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class SupportTerritoryConfiguration : EntityTypeConfiguration<SupportTerritory>
    {
        public SupportTerritoryConfiguration()
        {
            ToTable("SupportTerritories");
            Property(d => d.SupportTerritoryName).IsRequired();
            Property(d => d.SupportTerritoryName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
