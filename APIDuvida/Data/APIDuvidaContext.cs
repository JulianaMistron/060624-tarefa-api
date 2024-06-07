﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Duvida;

namespace APIDuvida.Data
{
    public class APIDuvidaContext : DbContext
    {
        public APIDuvidaContext (DbContextOptions<APIDuvidaContext> options)
            : base(options)
        {
        }

        public DbSet<Duvida.DuvidaModel> DuvidaModel { get; set; } = default!;
    }
}
