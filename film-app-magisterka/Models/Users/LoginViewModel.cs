using System.ComponentModel.DataAnnotations;

namespace film_app_magisterka.Models.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić nazwę użytkownika.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Musisz wprowadzić hasło.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
