﻿namespace AulaUmTumaH.Domain.Entities
{
    public class Aluno : Pessoa
    {
        public int IdEscola { get; set; }
        public Escola Escola { get; set; }        
    }
}