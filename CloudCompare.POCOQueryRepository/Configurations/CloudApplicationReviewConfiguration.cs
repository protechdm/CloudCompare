﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class CloudApplicationReviewConfiguration : EntityTypeConfiguration<CloudApplicationReview>
    {
        public CloudApplicationReviewConfiguration()
        {
            ToTable("CloudApplicationReviews");
            Property(d => d.CloudApplicationReviewDate).IsRequired();
            Property(d => d.CloudApplicationReviewPublisherName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}