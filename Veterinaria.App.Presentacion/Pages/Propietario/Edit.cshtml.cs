using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia.AppRepositorios;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class EditModel : PageModel
    {
       private readonly IRepositorioPropietario RepositorioPropietario;
        [BindProperty]
        public Propietario Propietario {get;set;}

        public EditModel(IRepositorioPropietario RepositorioPropietario)
        {
            this.RepositorioPropietario = RepositorioPropietario;

        }  
        public IActionResult OnGet(int? PropietarioId)
        {
            if (PropietarioId.HasValue)
            {
                Propietario = RepositorioPropietario.GetPropietario(PropietarioId.Value);
            }
            else
            {
                Propietario = new Propietario();
            }
            if (Propietario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Propietario.Id>0)
            {
            Propietario = RepositorioPropietario.UpdatePropietario(Propietario);
            }
            else
            {
             RepositorioPropietario.AddPropietario(Propietario);
            }
            return Page();
        }

    }
}
