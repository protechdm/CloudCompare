using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class VendorConfiguration : EntityTypeConfiguration<Vendor>
    {
        public VendorConfiguration()
        {
            ToTable("Vendors");
            
            Property(d => d.VendorName).IsRequired();
            Property(d => d.VendorName).HasMaxLength(103);
            Property(d => d.VendorName).HasColumnName("VendorName");
            Property(d => d.VendorLogo).HasColumnType("image");
            Property(d => d.RowVersion).IsRowVersion();
            HasMany(d => d.CloudApplications).WithRequired(v => v.Vendor);

        }
    }
}
