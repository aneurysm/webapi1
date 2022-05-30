using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}