using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASPNETIdentityManager.Entities
{
    public class Prenotazione : IdentityUser
    {
        [NotMapped]
        public string Dal { get; set; }
        [NotMapped]
        public string Al { get; set; }
        [NotMapped]
        public int Persone { get; set; }
        [NotMapped]
        public string Pacchetto { get; set; }
    }
}
