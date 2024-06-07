using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oportunidade;

namespace APIOPortunidade.Data
{
    public class APIOPortunidadeContext : DbContext
    {
        public APIOPortunidadeContext (DbContextOptions<APIOPortunidadeContext> options)
            : base(options)
        {
        }

        public DbSet<Oportunidade.OportunidadeModel> OportunidadeModel { get; set; } = default!;
    }
}
