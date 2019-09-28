using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore_EnviaExibeImagem.Models
{
    public class ImagemDbContext : DbContext
    {
        public ImagemDbContext(DbContextOptions<ImagemDbContext> options) : base(options)
        { }
        public DbSet<Imagem> Imagens { get; set; }
    }
}
