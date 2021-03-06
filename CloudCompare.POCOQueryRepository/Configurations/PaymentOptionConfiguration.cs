﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class PaymentOptionConfiguration : EntityTypeConfiguration<PaymentOption>
    {
        public PaymentOptionConfiguration()
        {
            ToTable("PaymentOptions");
            Property(d => d.PaymentOptionName).IsRequired();
            Property(d => d.PaymentOptionName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
