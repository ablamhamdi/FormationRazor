using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Foramation.DTO
{
    public class Resto
    {

        public int id { get; set; }
        [BindProperty]
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string name { get; set; }
        [BindProperty]
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Discription { get; set; }
        [BindProperty]
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Address { get; set; }
        [BindProperty]
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string PhoneNumber { get; set; }

    }
}
