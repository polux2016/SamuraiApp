using System.ComponentModel.DataAnnotations;

namespace SamuraiApp.Domain
{
    public class Quote
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public Samurai Samurai { get; set; }
    }
}
