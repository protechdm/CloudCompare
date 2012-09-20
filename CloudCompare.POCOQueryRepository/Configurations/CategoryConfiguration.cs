using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations

{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            Property(d => d.CategoryName).IsRequired();
            Property(d => d.CategoryName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
