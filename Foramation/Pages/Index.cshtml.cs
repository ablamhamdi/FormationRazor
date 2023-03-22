using Foramation.DTO;
using Foramation.Module;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foramation.Pages
{
    public class IndexModel : PageModel
    {
        //public RestorantService Foramation { get; set; }
        private readonly ILogger<IndexModel> _logger;
        string strConnection = string.Empty;
       
        //IRestorant restorant;

        //public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger, IRestorant restorant)
        //{
        //    //strConnection = configuration["ConnectionStrings"];
        //    //_logger = logger;
        //    //Foramation = new RestorantService();
        //    //this.restorant = restorant;
        //}
        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            strConnection = configuration["stringCon"];
            _logger = logger;
            _logger.LogWarning("msg warning");

            //Foramation = new RestorantService();
            //this.restorant = restorant;
        }

        public void OnGet()
        {

        }
    }
}