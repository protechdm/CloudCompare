using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class PaymentFrequencyConfiguration : EntityTypeConfiguration<PaymentFrequency>
    {
        public PaymentFrequencyConfiguration()
        {
            ToTable("PaymentFrequencies");
            Property(d => d.PaymentFrequencyName).IsRequired();
            Property(d => d.PaymentFrequencyName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
