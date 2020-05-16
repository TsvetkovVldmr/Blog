using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.DbTools.Models
{
    public class MusicGenre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Archetype { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public string Comment { get; set; }
    }
}
