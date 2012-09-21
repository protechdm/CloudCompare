﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class ThumbnailDocumentTypeConfiguration : EntityTypeConfiguration<ThumbnailDocumentType>
    {
        public ThumbnailDocumentTypeConfiguration()
        {
            ToTable("ThumbnailDocumentTypes");
            Property(d => d.ThumbnailDocumentTypeName).IsRequired();
            Property(d => d.ThumbnailDocumentTypeName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}