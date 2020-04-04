using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducatioNow.Models
{
    public class Professor
    {
        public string Nome { get; set; }

        public int Id { get; set; }

        public string Email { get; set; }

        public DateTime DtNascimento { get; set; }

        public string Senha { get; set; }
    }
}
