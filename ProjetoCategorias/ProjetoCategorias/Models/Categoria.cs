using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCategorias.Models
{
    public class Categoria : IComparable<Categoria>
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public int CompareTo(Categoria cat)
        {
            return CategoriaId.CompareTo(cat.CategoriaId);
            throw new NotImplementedException();
        }
    }
    }
