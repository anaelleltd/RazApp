﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazApp.Data;
using RazApp.Models;

namespace RazApp.Pages.Books
{
    public class BooksModel : PageModel
    {
        private readonly RazApp.Data.RazAppContext _context;

        public BooksModel(RazApp.Data.RazAppContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
