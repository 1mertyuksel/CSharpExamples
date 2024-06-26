﻿using CompanyInfo.EntityConfig.Abstract;
using CompanyInfo.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.EntityConfig.Concrete
{
    public class UrunConfig:BaseConfig<Urun>
    {

        public override void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.UrunKodu).HasMaxLength(50);
            builder.Property(p => p.UrunAdi).HasMaxLength(50);
            builder.HasIndex(p=> p.UrunKodu).IsUnique();



        }
    }
}
