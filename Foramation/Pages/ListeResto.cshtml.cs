using Foramation.DTO;
using Foramation.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foramation.Pages
{
    public class ListeRestoModel : PageModel
       
    {
        private readonly Irepo restaurantRepository;
        public List<Resto> Restos { get; set; }
        public ListeRestoModel(Irepo restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

      
        public void OnGet()
        {
            Restos = restaurantRepository.GetResautrants();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {

            restaurantRepository.DeleteRestaurant(id);

            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {

            return RedirectToPage("Edit", "SingleOrder", new { orderId = id });
        }
    }
}
