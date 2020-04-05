using Dapper;
using EducatioNow.Models;
using EducatioNow.Utils;
using Microsoft.Extensions.Options;
using System;

namespace EducatioNow.Data
{
    public class AlunoRepository : Repository
    {
        public AlunoRepository(IOptions<ConnectionStringOption> connectionString) : base(connectionString) { }

        public Aluno GetAluno(int id)
        {
            try
            {
                using (var connection = CreateOracleConnection())
                {
                    return connection.QueryFirst<Aluno>("");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro durante a busca do aluno.", ex);
            }
        }
    }
}
