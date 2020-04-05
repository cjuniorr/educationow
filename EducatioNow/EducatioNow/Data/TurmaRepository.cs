using Dapper;
using EducatioNow.Data.Interfaces;
using EducatioNow.Models;
using EducatioNow.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducatioNow.Data
{
    public class TurmaRepository : Repository, ITurmaRepository
    {
        public TurmaRepository(IOptions<ConnectionStringOption> connectionString): base(connectionString) { }

        public Task Create(Turma turma)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Turma>> Get()
        {
            try
            {
                using (var connection = CreateOracleConnection())
                {
                    //var turmas = await connection.QueryAsync<Turma>(@"SELECT ID FROM RM83652.ALUNO ORDER BY ID DESC");

                    var turmas = GetMock();

                    return turmas;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro durante a criação da turma", ex);
            }
        }

        private List<Turma> GetMock()
        {
            var turmas = new List<Turma>
            {
                new Turma { Id = "AAA", Ano = 2020, Serie = 1 },
                new Turma { Id = "BBB", Ano = 2019, Serie = 2 },
                new Turma { Id = "CCC", Ano = 2018, Serie = 2 },
                new Turma { Id = "DDD", Ano = 2020, Serie = 3 }
            };

            return turmas;
        }
    }
}
