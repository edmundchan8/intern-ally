using System.Collections;
using System.Collections.Generic;

namespace intern_ally.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillType { get; set; }
        public int MonthsExperience { get; set; }
        public int YearsExperience { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}