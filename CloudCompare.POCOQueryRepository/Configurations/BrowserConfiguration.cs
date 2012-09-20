using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class BrowserConfiguration : EntityTypeConfiguration<Browser>
    {
        public BrowserConfiguration()
        {
            ToTable("Browsers");
            Property(d => d.BrowserName).IsRequired();
            Property(d => d.BrowserName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
