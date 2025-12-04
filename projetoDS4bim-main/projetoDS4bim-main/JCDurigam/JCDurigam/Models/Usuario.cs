namespace JCDurigam.Models
{
    public class Usuario
    {
        public int Id { get; set; } // PK

        public string NomeComp { get; set; }

        public string Email { get; set; }

        public decimal Telefone { get; set; }
    }
}