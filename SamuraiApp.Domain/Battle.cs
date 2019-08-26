using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SamuraiApp.Domain
{
    public class Battle
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<SamuraiBattle> SamuraiBattle { get; set; }
    }
}
