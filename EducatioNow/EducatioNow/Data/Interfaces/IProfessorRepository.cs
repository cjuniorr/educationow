using EducatioNow.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducatioNow.Data.Interfaces
{
    interface IProfessorRepository
    {
        Task<IEnumerable<Professor>> GetProfessors();

        Task Create(Professor professor);

        Task AddNaTurma(string professorId, string turmaId);
    }
}
