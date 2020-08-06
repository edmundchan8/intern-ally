using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intern_ally.Models
{
    public class Recruiter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public ICollection<SocialMedia> SocialMedia { get; set; }
    }
}
