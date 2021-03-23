using JB_AppModelo_Site.Data;
using JB_AppModelo_Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace JB_AppModelo_Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _context;


        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "João",
                DataNascimento = Convert.ToDateTime("19/12/1996"),
                Email = "teste@gmail.com"
            };

            _context.Add(aluno);

            _context.SaveChanges();

            return View();
        }
    }
}
