using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Puhkus
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime Algus { get; set; }
        public DateTime Lõpp { get; set; }
        public string Põhjus { get; set; }
    }
}
