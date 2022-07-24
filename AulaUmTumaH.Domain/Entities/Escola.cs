namespace AulaUmTumaH.Domain.Entities
{
    public class Escola : EntityBase
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string CNPJ { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public DateTime HorarioFuncionamento { get; set; }

        public string Estado { get; set; }

        public ICollection<Coordenador> Coordenadores { get; set; }
    }
}