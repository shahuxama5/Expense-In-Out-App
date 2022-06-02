using ExpenseInAndOut.Data;
using ExpenseInAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpenseInAndOut.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get List
        public IActionResult Index()
        {
            IEnumerable<Expense> expenses = _context.Expenses;
            return View(expenses);
        }

        // Get Create
        public IActionResult Create()
        {
            return View();
        }

        // Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        // Get Delete
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var expense = _context.Expenses.Find(id);
            if(expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        // Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense == null)
            {
                return NotFound();
            }
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Get Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var expense = _context.Expenses.Find(id);
            if (expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        // Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Update(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
