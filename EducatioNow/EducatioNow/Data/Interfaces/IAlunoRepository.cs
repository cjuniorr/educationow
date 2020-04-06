using EducatioNow.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducatioNow.Data.Interfaces
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> GetAlunos();

        Task Create(Aluno aluno);

        Task AddNaTurma(int alunoId, string turmaId);
    }
}
