using System;

namespace JB_AppModelo_Site.Models
{
    public class Aluno
    {

        public Aluno()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
