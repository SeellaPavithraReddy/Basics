using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EFApp.Views.Sample
{
    public class Index3 : PageModel
    {
        private readonly ILogger<Index3> _logger;

        public Index3(ILogger<Index3> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}