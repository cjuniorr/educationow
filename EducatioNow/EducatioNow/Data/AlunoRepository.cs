using Dapper;
using EducatioNow.Data.Interfaces;
using EducatioNow.Models;
using EducatioNow.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducatioNow.Data
{
    public class AlunoRepository : Repository, IAlunoRepository
    {
        public AlunoRepository(IOptions<ConnectionStringOption> connectionString) : base(connectionString) { }

        public Task<IEnumerable<Aluno>> GetAlunos()
        {
            try
            {
                using (var connection = CreateOracleConnection())
                {
                    var aluno = connection.QueryAsync<Aluno>(@"SELECT ID, TURMAID, NOME, ENDERECOID, TELEFONEID, EMAIL, DTNASCIMENTO FROM RM83652.ALUNO");
                    return aluno;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro durante a busca do aluno.", ex);
            }
        }
    }
}
