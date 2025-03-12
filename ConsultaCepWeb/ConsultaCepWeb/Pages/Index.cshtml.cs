using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services;

namespace ConsultaCepWeb.Pages;

public class IndexModel : PageModel
    {
    private readonly ViaCepService _viaCepService;

    public IndexModel(ViaCepService viaCepService)
        {
        _viaCepService = viaCepService;
        }

    [BindProperty]
    public string? Cep { get; set; }
    public Endereco? Endereco { get; set; }

    public async Task<IActionResult> OnPostAsync()
        {
        if(!string.IsNullOrWhiteSpace(Cep))
            {
            Endereco = await _viaCepService.ConsultaCepAsync(Cep);
            }
        return Page();
        }
    }
