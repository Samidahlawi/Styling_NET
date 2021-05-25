using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksStore.Controllers
{
    public class BooksController : Controller
    {
        private List<BookModel> _Books = new List<BookModel>()
        {
            new BookModel { Id = 1, Title = "فن اللامبالاة", Author = "مارك مانسون", Price=40.9f , Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb6360na007.jpg?1"},
            new BookModel { Id = 2, Title = "تذكر من أنت", Author = "دايزي", Price=22.0f , Image = "https://images-na.ssl-images-amazon.com/images/I/41V2z+gErhL._SX331_BO1,204,203,200_.jpg"},
            new BookModel { Id = 3, Title = "‎حياة في الادارة", Author = "غازي القصيبي", Price=60.2f , Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/1/2/122949.jpg?1"},
            new BookModel { Id = 4, Title = "‎ابق قويا 365 يوما في السنة‎", Author = "ديمي لوفاتو", Price=44.3f , Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/1/419110.jpg?1"},
            new BookModel { Id = 5, Title = "‎حضارة العرب‎", Author = "غوستاف لو بون", Price=21.0f , Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/1/514527.jpg?1"},
            new BookModel { Id = 6, Title = "أنت المؤلف", Author = "عبير الحوسني", Price=63.8f , Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb6910na018.jpg?1"},
            new BookModel { Id = 7, Title = "نظرية الفستق", Author = "فهد الأحمدي", Price=77.3f , Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/6/464184.jpg?1"},
        };

        // GET: /books/
        // GET: /books/index
        public IActionResult Index()
        {
            ViewData["Books"] = _Books;
            return View();
        }

        // GET: /books/detials/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("Page NotFound");
            }
            else
            {
                BookModel Book = _Books.Find(b => b.Id == id);
                ViewData["Book"] = Book;
                return View();
            }
        }
    }
}
