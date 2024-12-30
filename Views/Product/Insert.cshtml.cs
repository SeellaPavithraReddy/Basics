using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EFApp.Views.Product
{
    public class Insert : PageModel
    {
        private readonly ILogger<Insert> _logger;

        public Insert(ILogger<Insert> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}