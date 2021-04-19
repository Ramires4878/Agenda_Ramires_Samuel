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
            return View(Agendas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(AgendaPessoal P)
        {
            P.AgendaID = Agendas.Select(ID => ID.AgendaID).Max() + 1;
            Agendas.Add(P);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(long id)
        {
            return View(Agendas.Where(ID => ID.AgendaID == id).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(AgendaPessoal P)
        {
            Agendas.Remove(Agendas.Where(ID => ID.AgendaID == P.AgendaID).First());
            Agendas.Add(P);
            return RedirectToAction("Index");
        }

        public IActionResult Details(long id)
        {
            return View(Agendas.Where(ID => ID.AgendaID == id).First());
        }

        public IActionResult Delete(long id)
        {
            return View(Agendas.Where(ID => ID.AgendaID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(AgendaPessoal P)
        {
            Agendas.Remove(Agendas.Where(ID => ID.AgendaID == P.AgendaID).FirstOrDefault());
            return RedirectToAction("Index");
        }
    }
}
