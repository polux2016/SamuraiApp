using System.ComponentModel.DataAnnotations;

namespace SamuraiApp.Domain
{
    public class SamuraiBattle
    {
        [Key]
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
        [Key]
        public int BattleId { get; set; }
        public Battle Battle { get; set; }

    }
}
