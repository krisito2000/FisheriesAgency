using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FisheriesAgency.Model
{
    class UserModel
    {
        private int id;
        private string username;
        private string password;

        [DisplayName("ID")]
        public int UserID { get => id; set => id = value; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 50 characters.")]
        public string Username { get => username; set => username = value; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, MinimumLength = 7, ErrorMessage = "Password must be between 7 and 50 characters.")]
        public string Password { get => password; set => password = value; }
        public UserModel()
        {

        }
    }
}
