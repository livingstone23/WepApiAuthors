using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppiAuthors.Entities;

namespace WebAppiAuthors.Services
{
    public interface IRepositorioAuthors
    {
        Author ObtenerPorId(int id);
    }
}
