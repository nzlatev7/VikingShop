using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VikingShop.Models.Response
{
    public class UserGetAllResponse
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public bool? IsEmailConfirmed { get; set; }
    }
}
