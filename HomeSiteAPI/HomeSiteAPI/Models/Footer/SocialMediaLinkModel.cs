using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSiteAPI.Models.Footer
{
    public class SocialMediaLinkModel
    {
        public int Id { get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string URLLink { get; set; }
        public string ImageURL { get; set; }

    }
}
