using GoldyGopher.Models;
using GoldyGopher.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace GoldyGopher.Pages;

    public class IndexModel : PageModel
    {
        private readonly INumbers _numbers;

    [BindProperty]
    public NumberInput NumberInput { get; set; }
    public NumberOutput NumberOutput { get; set; }

        public IndexModel(INumbers numbers)
        {
            _numbers = numbers;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NumberOutput = _numbers.CalculateGoldyGopher(NumberInput);

            return Page();
        }
    }

