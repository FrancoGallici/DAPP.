using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DB.Data.Entities
{
    public partial class Spells
    {
        
        public int Id { get; set; }

        public string Name { get; set; }
        public string Casting_Time { get; set; }

        public string Components { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int Level { get; set; }
        public string Range { get; set; }
        public string School { get; set; }
       
    }
}