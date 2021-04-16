using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaGit.Models;

namespace AgendaGit.Controllers
{
    public class AgendaPessoalController : Controller
    {
        private static IList<AgendaPessoal> Agendas = new List<AgendaPessoal>()
        {
            new AgendaPessoal()
            {
                AgendaID = 1,
                Nome = "Ramires",
                Idade = 20,
                TelefoneCelular = "988010203",
                TelefoneFixo = "32912020",
                Email = "ramires@gmail.com"
            },
            new AgendaPessoal()
            {
                AgendaID = 2,
                Nome = "Samuel",
                Idade = 19,
                TelefoneCelular = "911223344",
                TelefoneFixo = "32912121",
                Email = "samuel@gmail.com"
            },
            new AgendaPessoal()
            {
                AgendaID = 3,
                Nome = "Paulo",
                Idade = 22,
                TelefoneCelular = "988015656",
                TelefoneFixo = "32929898",
                Email = "paulo@gmail.com"
            },
            new AgendaPessoal()
            {
                AgendaID = 4,
                Nome = "Joao",
                Idade = 56,
                TelefoneCelular = "998567893",
                TelefoneFixo = "32926753",
                Email = "joao@gmail.com"
            },
        };

        public IActionResult Index()
        {
            return View();
        }
    }
}
