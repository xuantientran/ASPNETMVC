using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCLoginDemo.Models
{
    public class ClsUserBO
    {
        [Required(ErrorMessage = "User name is compulsary")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is compulsary")]
        public string Password { get; set; }
    }
}