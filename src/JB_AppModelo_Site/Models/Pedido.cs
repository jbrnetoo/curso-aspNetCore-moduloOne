using System;

namespace JB_AppModelo_Site.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Pedido()
        {
            Id = Guid.NewGuid();
        }
    }
}
