using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QueerTrip.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QUeerTrip.Controllers
{
    public class HomeController : Controller
    {

        private DbContext _context;

        public HomeController(userDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Index()
        {

            List<user> users = _context.users.ToList();

            if(users == null)
            {
                return View("Cadastro");
            }

            return View(users);
        }

        [HttpPost]
        public IActionResult Index(user users)
        {
            if(User == null)
            {
                return View("Cadastro");
            }

            _context.Add(User);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {

            user user = _context.users.Find(id);

            return View(user);
        }

        [HttpPost]
        public IActionResult Editar(user user)
        {

            _context.Update(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {

            user user = _context.users.SingleOrDefault(a => a.ID == id);

            if(user == null)
            {
                return RedirectToAction("Cadastro");
            }
            

            return View(user);
        }

        [HttpPost]
        public IActionResult Deletar(user users)
        {
            

            _context.Remove(User);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}

