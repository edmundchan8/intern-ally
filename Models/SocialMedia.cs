namespace intern_ally.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Company { get; set; }
        public Intern intern { get; set; }
    }
}