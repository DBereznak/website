using HomeSiteAPI.Models.Footer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSiteAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmailModel> Emails { get; set; }
        public DbSet<SocialMediaLinkModel> SocialMediaLink {get; set;}
    }
}
