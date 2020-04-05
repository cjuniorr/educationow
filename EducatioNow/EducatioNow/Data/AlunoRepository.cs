using Dapper;
using EducatioNow.Data.Interfaces;
using EducatioNow.Models;
using EducatioNow.Utils;
using Microsoft.Extensions.Options;
using System;

namespace EducatioNow.Data
{
    public class AlunoRepository : Repository, IAlunoRepository
    {
        public AlunoRepository(IOptions<ConnectionStringOption> connectionString) : base(connectionString) { }

        public Aluno GetAluno(int id)
        {
            try
            {
                using (var connection = CreateOracleConnection())
                {
                    var aluno = connection.QueryFirstOrDefault<Aluno>(@"SELECT ID, TURMAID, NOME, ENDERECOID, TELEFONEID, EMAIL, DTNASCIMENTO FROM RM83652.ALUNO");
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
