using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducatioNow.Models
{
    public class Turma
    {
        public int Id { get; set; }

        public string Serie { get; set; }

        public int Ano { get; set; }

        public IEnumerable<Aluno> Alunos { get; set; }
    }
}
