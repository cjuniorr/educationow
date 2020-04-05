using EducatioNow.Data;
using EducatioNow.Data.Interfaces;
using EducatioNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducatioNow.Controllers
{
    public class AlunoController : Controller
    {
        private readonly EducatioNowContext _context;
        private IAlunoRepository _alunoRepository;

        public AlunoController(EducatioNowContext context, IAlunoRepository alunoRepository)
        {
            _context = context;
            _alunoRepository = alunoRepository;
        }

        // GET: Aluno
        public async Task<IActionResult> Index()
        {
            var listaAlunos = new List<Aluno> {
                new Aluno { Id = 1, Nome = "Fulano de Tal", DtNascimento = DateTime.Now, Email = "qwert@abc.com.br", TelefoneId = "1234456789" },
                new Aluno { Id = 2, Nome = "Sincrano de Tal", DtNascimento = DateTime.Now, Email = "abc@abc.com.br", TelefoneId = "777777777" },
                new Aluno { Id = 3, Nome = "Beltrano de Tal", DtNascimento = DateTime.Now, Email = "asdf@abc.com.br", TelefoneId = "88888888" },
                new Aluno { Id = 4, Nome = "Deltrano de Tal", DtNascimento = DateTime.Now, Email = "yuio@abc.com.br", TelefoneId = "9999999999" }
            };

            var getAluno = _alunoRepository.GetAluno(1);

            return View(listaAlunos);
            //var teste = await _context.Aluno.ToListAsync();
            //return View(teste);
        }

        // GET: Aluno/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: Aluno/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,DtNascimento,Senha,Telefone")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        // GET: Aluno/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        // POST: Aluno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,DtNascimento,Senha,Telefone")] Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        // GET: Aluno/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: Aluno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _context.Aluno.FindAsync(id);
            _context.Aluno.Remove(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(int id)
        {
            return _context.Aluno.Any(e => e.Id == id);
        }
    }
}
