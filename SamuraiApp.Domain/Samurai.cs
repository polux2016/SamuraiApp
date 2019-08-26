using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public Samurai() => Quotes = new List<Quote>();

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public List<SamuraiBattle> SamuraiBattle { get; set; }
        
    }
}
