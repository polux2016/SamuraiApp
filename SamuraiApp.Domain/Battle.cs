using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SamuraiApp.Domain
{
    public class Battle : ClientChangeTracker
    {
        protected string name;

        [Key]
        public int Id { get; set; }
        public string Name 
        {
            get { return name; }
            set { SetField(ref name, value); }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<SamuraiBattle> SamuraiBattle { get; set; }
    }
}
