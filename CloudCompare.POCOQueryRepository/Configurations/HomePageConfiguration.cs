using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class HomePageConfiguration : EntityTypeConfiguration<HomePage>
    {
        public HomePageConfiguration()
        {
            ToTable("HomePage");
            //Property(d => d.SimpleSearchInputs.Categories).IsRequired();
        }
    }
}
