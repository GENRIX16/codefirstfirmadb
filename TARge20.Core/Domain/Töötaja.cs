using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Töötaja
    {
        [Key]
        public Guid ID { get; set; }
        public string Eesnimi { get; set; }
        public string Perenimi { get; set; }
        public ICollection<Ametinimetus> Ametinimetused_ID { get; set; }
        public ICollection<Haigusleht> Haiguslehed_ID { get; set; }
        public ICollection<Laenutamine> Laenutamised_ID { get; set; }
        public ICollection<Laps> Lapsed_ID { get; set; }
        public ICollection<Puhkus> Puhkused_ID { get; set; }
    }
}
