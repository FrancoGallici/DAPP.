using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class SpellViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Casting_Time { get; set; }
        [Required]
        public string Components { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public string Range { get; set; }
        [Required]
        public string School { get; set; }

    }
}
