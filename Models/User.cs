using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLenz.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(5)]
        public string Email { get; set; }
        [MinLength(5)]
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public List<AccessRight> AccessRights { get; set; }

    }
}
