using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SocialLogin.Data;
using SocialLogin.Models;

namespace SocialLogin.Views.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly SocialLogin.Data.ApplicationDbContext _context;

        public IndexModel(SocialLogin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get; set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}