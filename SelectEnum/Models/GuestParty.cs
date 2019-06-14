using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.Models
{
    public class GuestParty
    {
        [Key]
        public int GuestPartyID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? willAttnd { get; set; }

    }
}
