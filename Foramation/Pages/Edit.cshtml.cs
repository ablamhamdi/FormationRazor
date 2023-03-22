using Foramation.DTO;
using Foramation.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foramation.Pages
{
    public class EditModel : PageModel
    {
        private readonly Irepo restaurantRepository;
        public Resto Restos { get; set; }
        public EditModel(Irepo restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }
        public void OnGet()
        {
        }
        public void OnGetSingleOrder(int orderId)
        {
            Restos = restaurantRepository.getRestoById(orderId);
        }
      
        public async Task<IActionResult> OnPostAsync(Resto R)
        {
            restaurantRepository.UpdateResto(R);
            return RedirectToPage("ListeResto");
        }
    }
}
