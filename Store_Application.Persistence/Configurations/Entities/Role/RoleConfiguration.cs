﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Role
{
    public class RoleConfiguration : IEntityTypeConfiguration<Domain.Entities.User.Role>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User.Role> builder)
        {
            builder.HasKey(r => r.Id);
        }
    }
}
