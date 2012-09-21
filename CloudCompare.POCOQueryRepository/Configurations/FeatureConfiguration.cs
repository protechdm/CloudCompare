﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class FeatureConfiguration : EntityTypeConfiguration<Feature>
    {
        public FeatureConfiguration()
        {
            ToTable("Features");
            Property(d => d.FeatureName).IsRequired();
            Property(d => d.FeatureName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
            
        }
    }
}