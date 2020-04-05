using EducatioNow.Models;

namespace EducatioNow.Data.Interfaces
{
    public interface IAlunoRepository
    {
        Aluno GetAluno(int id);
    }
}
