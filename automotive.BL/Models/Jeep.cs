﻿using System.ComponentModel.DataAnnotations.Schema;

namespace automotive.BL.Models
{
    [Table("Jeep")]
    public class Jeep: Transport
    {
        public int Position { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
        public int Clearance { get; set; }
    }
}
