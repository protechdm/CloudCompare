using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class MinimumContractConfiguration : EntityTypeConfiguration<MinimumContract>
    {
        public MinimumContractConfiguration()
        {
            ToTable("MinimumContracts");
            Property(d => d.MinimumContractName).IsRequired();
            Property(d => d.MinimumContractName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
