using Foramation.DTO;
using Foramation.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;

namespace Foramation.Pages
{
    public class addRestoModel : PageModel
    {


        private readonly Irepo restaurantRepository;
        public List<Resto> Restos { get; set; }
        public addRestoModel(Irepo restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

        public void OnGet()
        {
        }

        public void OnPost(string name) {
         

        }
        public void OnPostSubmit(Resto R)
        {
           
            restaurantRepository.addResto(R);
          
        }
    }
}
