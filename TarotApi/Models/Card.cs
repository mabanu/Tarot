using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TarotApi.Models
{
    public partial class Card
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Number { get; set; } = null!;
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string Element { get; set; } = null!;
        [StringLength(150)]
        public string Image { get; set; } = null!;
        [StringLength(150)]
        public string Link { get; set; } = null!;
    }
}
