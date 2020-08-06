using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intern_ally.Models
{
    public class Intern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentJobTitle { get; set; }
        public string Email { get; set; }
        public ICollection<SocialMedia> SocialMedia { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
