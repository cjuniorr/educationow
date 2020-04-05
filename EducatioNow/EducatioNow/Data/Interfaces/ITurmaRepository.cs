using EducatioNow.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducatioNow.Data.Interfaces
{
    public interface ITurmaRepository
    {
        Task<IEnumerable<Turma>> Get();

        Task Create(Turma turma);

        Task AddAluno(string alunoId);
    }
}
