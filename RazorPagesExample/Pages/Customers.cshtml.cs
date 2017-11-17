using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesExample.Data;
using RazorPagesExample.Models;

namespace RazorPagesExample.Pages
{
    public class CustomersModel : PageModel
    {
        private CustomersDbContext _context;
        
        public CustomersModel(CustomersDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Customer> Customers { get; set; }

        public void OnGet()
        {            
            Customers = _context.Customers.ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        
    }
}