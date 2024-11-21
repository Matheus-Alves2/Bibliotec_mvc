using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        [Key]
        // Propriedades
        [ForeignKey("Livro")]
        public int LivroCategoriaID { get; set; }
        public Livro Livro { get; set; }
        public int LivroID { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }
        public int Categoria { get; set; }
    }
}