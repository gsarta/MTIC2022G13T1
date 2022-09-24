using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;

        public IEnumerable<Dueno> listaDuenos {get;set;}

        public listaDuenosModel()
        {
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContex());
        }
        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
        }
    }
}
