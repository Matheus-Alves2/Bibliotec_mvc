using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{

    public class Usuario
    {
        [Key]
        // Propriedades
        public int UsuarioID { get; set; }
        public DateOnly DtNascimento { get; set; }
        public string? Nome { get; set; }
        public string? Escritor { get; set; }
        public string? Editora { get; set; }
        public string? Descricao { get; set; }
        public string? Idioma { get; set; }
        public string? Imagem { get; set; }
        public bool Adimin { get; set; }
        public bool status { get; set; }

        [ForeignKey("Curso")]
        public int CursoID { get; set; }
        public Curso curso{ get; set; }
}

    public class Curso
    {
    }
}