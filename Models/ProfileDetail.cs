using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProfileDetail.Models
{
    public class ProfileDetail
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string WebsiteURL { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePhoto { get; set; }
        public string LinkedInUrl { get; set; }



    }
}
