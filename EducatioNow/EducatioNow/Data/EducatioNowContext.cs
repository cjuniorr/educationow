using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducatioNow.Models;

namespace EducatioNow.Data
{
    public class EducatioNowContext : DbContext
    {
        public EducatioNowContext (DbContextOptions<EducatioNowContext> options)
            : base(options)
        {
        }

        public DbSet<EducatioNow.Models.Aluno> Aluno { get; set; }

        public DbSet<EducatioNow.Models.Turma> Turma { get; set; }

        public DbSet<EducatioNow.Models.Professor> Professor { get; set; }
    }
}
