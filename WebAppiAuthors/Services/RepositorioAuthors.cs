using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppiAuthors.Contexts;
using WebAppiAuthors.Entities;

namespace WebAppiAuthors.Services
{
    public class RepositorioAuthors : IRepositorioAuthors
    {
        private readonly ApplicationDbContext context;

        public RepositorioAuthors(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Author ObtenerPorId(int id)
        {
            return context.Authors.FirstOrDefault(x => x.Id == id);
        }
    }
}