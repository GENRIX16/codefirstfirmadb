using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Laps
    {
        [Key]
        public Guid ID { get; set; }
        public string Nimi { get; set; }
        public DateTime Sünnipäev { get; set; }
    }
}
