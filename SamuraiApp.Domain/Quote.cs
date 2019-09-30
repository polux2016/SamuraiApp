using System.ComponentModel.DataAnnotations;

namespace SamuraiApp.Domain
{
    public class Quote: ClientChangeTracker
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public Samurai Samurai { get; set; }
    }
}
