namespace CadastroDeUsuarios.Models
{
    public class Usuario
    {
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required int Idade { get; set; }
    }
}