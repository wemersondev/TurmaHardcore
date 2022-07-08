namespace AulaUmTumaH.Domain.Entities
{
    public class Coordenador : Pessoa
    {
        public int EscolaId { get; set; }

        public Escola Escola { get; set; }
    }
}